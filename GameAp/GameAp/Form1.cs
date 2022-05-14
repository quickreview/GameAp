namespace GameAp
{
    public partial class Form1 : Form
    {
        // имя хп урон вес количество золота 
        Hero hero = new Hero("Knight", 100, 10, 20, 100);

        // имя хп урон , множитель по мобу вес количество золота
        static Enemy Принц  =       new Enemy("Принц", 100, 10,  20, 50);
        static Enemy Темный_принц = new Enemy("Темный_принц", 150, 15,  20, 100);
        static Enemy Дракончик =    new Enemy("Дракончик", 250 , 30,  20, 200);
        static Enemy Мегарыцарь =   new Enemy("Мегарыцарь", 400, 25,  20, 500);

        // цена урон хил
        static Items elixirLow = new Items(50, 0, 50);
        static Items elixirHight= new Items(100, 0, 150);

        static Items broadSword = new Items(100, 20, 0);
        static Items buffBroadSword = new Items(150, 30, 0);

        static int countLevel = 0; 


        static Enemy[] arrayEnemy = new Enemy[] { Принц, Темный_принц, Дракончик, Мегарыцарь };
       
        public Form1()
        {
            InitializeComponent();
            textBox1_TextChanged_1(this, null);
            textBox2_TextChanged(this, null);

            pictureBox4_Click(this, null);

            label1_Click(this, null);











            textBox1_TextChanged(this, null);
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            heroHP.Text = $"{hero.HealthPoint}/{hero.MaxHealthPoint}";
            heroHP.TextAlign = HorizontalAlignment.Center;
            heroHP.CharacterCasing = CharacterCasing.Lower;
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            label1.Text = $"{hero.CurrentGold}";

            Enemy enemy = arrayEnemy[countLevel];


            hero.Attack(enemy);
         

            
            



         
            enemyHP.Text = $"{enemy.HealthPoint}/{enemy.MaxHealthPoint}";
            heroHP.Text = $"{hero.HealthPoint}/{hero.MaxHealthPoint}";

            if (countLevel == 1) { enemyImage1.Visible = false; enemyImage2.Visible = true; }
            if (countLevel == 2) { enemyImage2.Visible = false; enemyImage3.Visible = true; }
            if (countLevel == 3) { enemyImage3.Visible = false; enemyImage4.Visible = true; }

            if ( enemy.HealthPoint <= 0 && countLevel < 4 )
            {
                countLevel++;
                hero.CurrentGold += enemy.CurrentGold;
                label1.Text = $"{hero.CurrentGold}";
                hero.HealthPoint += 100 ;
            }

            if (hero.HealthPoint <= 0)
            {
                pictureBox3.Visible = true;
                button1.Enabled = false;
            }
            if (enemy.HealthPoint <= 0 && countLevel == 4)
            {
                MessageBox.Show("Победа");
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

            
            enemyHP.TextAlign = HorizontalAlignment.Center;
            enemyHP.CharacterCasing = CharacterCasing.Lower;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
           
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            pictureBox4.BackColor = Color.Transparent;
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
           /*
            textBox1.TextAlign = HorizontalAlignment.Center;
            textBox1.CharacterCasing = CharacterCasing.Lower;
           */
        }

       

        private void button2_Click_1(object sender, EventArgs e)
        {


            hero.buyItem(elixirLow);
            heroHP.Text = $"{hero.HealthPoint}/{hero.MaxHealthPoint}";
            label1.Text = $"{hero.CurrentGold}";
        }

        private void ItemShop2_Click(object sender, EventArgs e)
        {

            hero.buyItem(elixirHight);
            heroHP.Text = $"{hero.HealthPoint}/{hero.MaxHealthPoint}";
            label1.Text = $"{hero.CurrentGold}";
        }

        private void ItemShop3_Click(object sender, EventArgs e)
        {

            hero.buyItem(broadSword);
         
            heroHP.Text = $"{hero.HealthPoint}/{hero.MaxHealthPoint}";
            label1.Text = $"{hero.CurrentGold}";
        }

        private void ItemShop4_Click(object sender, EventArgs e)
        {

            hero.buyItem(buffBroadSword);
           
            heroHP.Text = $"{hero.HealthPoint}/{hero.MaxHealthPoint}";
            label1.Text = $"{hero.CurrentGold}";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            hero.takeItem();
            label1.Text = $"{hero.CurrentGold}";
        }
    }
}