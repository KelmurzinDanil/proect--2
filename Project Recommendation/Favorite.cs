using DB_993;

namespace design
{
    public partial class Favorite : Form
    {
        public int IdRealryForFav { get; set; }
        public List<Realty> ListRealty { get; set; }
        public Favorite()
        {

            InitializeComponent();
            LoadData();
        }
        public Favorite(int idRealty)
        {
            IdRealryForFav = idRealty;
            FillTableFavourites();
            InitializeComponent();

        }
        private void FillTableFavourites()
        {
            using (var context = new ApplicationContex())
            {
                var existingUser = context.Favourites.FirstOrDefault(fav => fav.Id_Realty == IdRealryForFav);
                if (existingUser != null)
                {
                    MessageBox.Show("У вас этот объект уже находится в избранном");
                    return;
                }
                var newFav = new Favourites
                {
                    Id_Realty = IdRealryForFav
                };
                context.Favourites.Add(newFav);
                context.SaveChanges();
            }
        }
        private void LoadData()
        {
            using (var context = new ApplicationContex())
            {
                var imageList = new ImageList();
                imageList.ImageSize = new Size(100, 100);
                var tableFav = context.Favourites.ToList();
                var listRealty = new List<Realty>();
                for (int i = 0; i < tableFav.Count; i++)
                {
                    var itemRealty = context.Realtys.FirstOrDefault(realty => realty.Id == tableFav[i].Id_Realty);
                    listRealty.Add(itemRealty!);
                }
                ListRealty = listRealty;
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
