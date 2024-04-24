﻿using DB_993;

namespace design
{
    public partial class BlackList : Form
    {
        public int IdRealryForFav { get; set; }
        public BlackList()
        {
            InitializeComponent();
            LoadData();
            ProfileButton.Parent = Picture6;
            ProfileButton.BackColor = Color.Transparent;
            ProfileButton.FlatAppearance.BorderSize = 0;
            ProfileButton.FlatStyle = FlatStyle.Flat;
            FavButton.Parent = Picture6;
            FavButton.BackColor = Color.Transparent;
            FavButton.FlatAppearance.BorderSize = 0;
            FavButton.FlatStyle = FlatStyle.Flat;
            BlackListButton.Parent = Picture6;
            BlackListButton.BackColor = Color.Transparent;
            BlackListButton.FlatAppearance.BorderSize = 0;
            BlackListButton.FlatStyle = FlatStyle.Flat;
            MyListsButton.Parent = Picture6;
            MyListsButton.BackColor = Color.Transparent;
            MyListsButton.FlatAppearance.BorderSize = 0;
            MyListsButton.FlatStyle = FlatStyle.Flat;
        }
        public BlackList(int idRealty)
        {
            IdRealryForFav = idRealty;
            FillTableFavourites();
            InitializeComponent();
            ProfileButton.Parent = Picture6;
            ProfileButton.BackColor = Color.Transparent;
            ProfileButton.FlatAppearance.BorderSize = 0;
            ProfileButton.FlatStyle = FlatStyle.Flat;
            FavButton.Parent = Picture6;
            FavButton.BackColor = Color.Transparent;
            FavButton.FlatAppearance.BorderSize = 0;
            FavButton.FlatStyle = FlatStyle.Flat;
            BlackListButton.Parent = Picture6;
            BlackListButton.BackColor = Color.Transparent;
            BlackListButton.FlatAppearance.BorderSize = 0;
            BlackListButton.FlatStyle = FlatStyle.Flat;
            MyListsButton.Parent = Picture6;
            MyListsButton.BackColor = Color.Transparent;
            MyListsButton.FlatAppearance.BorderSize = 0;
            MyListsButton.FlatStyle = FlatStyle.Flat;
        }
        private void FillTableFavourites()
        {
            using (var context = new ApplicationContex())
            {
                var existingUser = context.BlackLists.FirstOrDefault(bl => bl.Id_Realty == IdRealryForFav);
                if (existingUser != null)
                {
                    MessageBox.Show("У вас этот объект уже находится в ЧС");
                    return;
                }
                var newBL = new BlackListTable
                {
                    Id_Realty = IdRealryForFav
                };
                context.BlackLists.Add(newBL);
                context.SaveChanges();
            }
        }
        private void LoadData()
        {
            using (var context = new ApplicationContex())
            {
                var imageList = new ImageList();
                imageList.ImageSize = new Size(100, 100);
                var tableBL = context.BlackLists.ToList();
                var listRealty = new List<Realty>();
                for (int i = 0; i < tableBL.Count; i++)
                {
                    var itemRealty = context.Realtys.FirstOrDefault(realty => realty.Id == tableBL[i].Id_Realty);
                    listRealty.Add(itemRealty!);
                }
                for (int i = 0; i < listRealty.Count; i++)
                {
                    imageList.Images.Add(new Bitmap(listRealty[i].PhotoRealty!));
                }
                listView1.SmallImageList = imageList;

                for (int i = 0; i < listRealty.Count; i++)
                {
                    var listViewItem = new ListViewItem(new string[] { String.Empty, listRealty[i].Price.ToString()!,
                        listRealty[i].Address!, listRealty[i].NameRealty!});
                    listViewItem.ImageIndex = i;
                    listView1.Items.Add(listViewItem);
                }
            }
        }

        private void BlackListButton_Click(object sender, EventArgs e)
        {
            listView1.Clear();
        }
    }
}
