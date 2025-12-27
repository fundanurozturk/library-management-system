namespace WindowsFormOdev.kutuphane
{
  partial class kitapEkle
  {
    /// <summary> 
    ///Gerekli tasarımcı değişkeni.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary> 
    ///Kullanılan tüm kaynakları temizleyin.
    /// </summary>
    ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Bileşen Tasarımcısı üretimi kod

    /// <summary> 
    /// Tasarımcı desteği için gerekli metot - bu metodun 
    ///içeriğini kod düzenleyici ile değiştirmeyin.
    /// </summary>
    private void InitializeComponent()
    {
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(kitapEkle));
      this.btnGetir = new System.Windows.Forms.PictureBox();
      this.cmbHasar = new System.Windows.Forms.ComboBox();
      this.label9 = new System.Windows.Forms.Label();
      this.btnYeni = new System.Windows.Forms.PictureBox();
      this.label7 = new System.Windows.Forms.Label();
      this.pictureBox10 = new System.Windows.Forms.PictureBox();
      this.cmbKitapTuru = new System.Windows.Forms.ComboBox();
      this.cmbTarih = new System.Windows.Forms.DateTimePicker();
      this.btnGuncelle = new System.Windows.Forms.PictureBox();
      this.btnSil = new System.Windows.Forms.PictureBox();
      this.btnEkle = new System.Windows.Forms.PictureBox();
      this.label8 = new System.Windows.Forms.Label();
      this.pictureBox7 = new System.Windows.Forms.PictureBox();
      this.txtStok = new System.Windows.Forms.TextBox();
      this.label5 = new System.Windows.Forms.Label();
      this.pictureBox4 = new System.Windows.Forms.PictureBox();
      this.label6 = new System.Windows.Forms.Label();
      this.pictureBox5 = new System.Windows.Forms.PictureBox();
      this.label3 = new System.Windows.Forms.Label();
      this.pictureBox2 = new System.Windows.Forms.PictureBox();
      this.txtYayinEvi = new System.Windows.Forms.TextBox();
      this.label4 = new System.Windows.Forms.Label();
      this.pictureBox3 = new System.Windows.Forms.PictureBox();
      this.txtYazar = new System.Windows.Forms.TextBox();
      this.label2 = new System.Windows.Forms.Label();
      this.pictureBox1 = new System.Windows.Forms.PictureBox();
      this.label1 = new System.Windows.Forms.Label();
      this.nameAnim = new System.Windows.Forms.PictureBox();
      this.txtBarkod = new System.Windows.Forms.TextBox();
      this.rTur = new System.Windows.Forms.RadioButton();
      this.rBarkod = new System.Windows.Forms.RadioButton();
      this.rKitap = new System.Windows.Forms.RadioButton();
      this.label11 = new System.Windows.Forms.Label();
      this.txtAra = new System.Windows.Forms.TextBox();
      this.pictureBox8 = new System.Windows.Forms.PictureBox();
      this.dtKitaplar = new System.Windows.Forms.DataGridView();
      this.cmbKitapAdi = new System.Windows.Forms.TextBox();
      ((System.ComponentModel.ISupportInitialize)(this.btnGetir)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.btnYeni)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.btnGuncelle)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.btnSil)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.btnEkle)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.nameAnim)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.dtKitaplar)).BeginInit();
      this.SuspendLayout();
      // 
      // btnGetir
      // 
      this.btnGetir.Image = ((System.Drawing.Image)(resources.GetObject("btnGetir.Image")));
      this.btnGetir.Location = new System.Drawing.Point(443, 149);
      this.btnGetir.Name = "btnGetir";
      this.btnGetir.Size = new System.Drawing.Size(150, 58);
      this.btnGetir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
      this.btnGetir.TabIndex = 109;
      this.btnGetir.TabStop = false;
      this.btnGetir.Click += new System.EventHandler(this.btnGetir_Click);
      // 
      // cmbHasar
      // 
      this.cmbHasar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.cmbHasar.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
      this.cmbHasar.FormattingEnabled = true;
      this.cmbHasar.Items.AddRange(new object[] {
            "Damaged",
            "Undamaged"});
      this.cmbHasar.Location = new System.Drawing.Point(443, 104);
      this.cmbHasar.MaximumSize = new System.Drawing.Size(150, 0);
      this.cmbHasar.MinimumSize = new System.Drawing.Size(150, 0);
      this.cmbHasar.Name = "cmbHasar";
      this.cmbHasar.Size = new System.Drawing.Size(150, 26);
      this.cmbHasar.TabIndex = 108;
      // 
      // label9
      // 
      this.label9.AutoSize = true;
      this.label9.BackColor = System.Drawing.Color.Yellow;
      this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
      this.label9.ForeColor = System.Drawing.Color.Crimson;
      this.label9.Location = new System.Drawing.Point(422, 227);
      this.label9.Name = "label9";
      this.label9.Size = new System.Drawing.Size(81, 20);
      this.label9.TabIndex = 106;
      this.label9.Text = "New Book";
      this.label9.Click += new System.EventHandler(this.label9_Click);
      // 
      // btnYeni
      // 
      this.btnYeni.Image = ((System.Drawing.Image)(resources.GetObject("btnYeni.Image")));
      this.btnYeni.Location = new System.Drawing.Point(367, 213);
      this.btnYeni.Name = "btnYeni";
      this.btnYeni.Size = new System.Drawing.Size(150, 50);
      this.btnYeni.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
      this.btnYeni.TabIndex = 105;
      this.btnYeni.TabStop = false;
      this.btnYeni.Click += new System.EventHandler(this.btnYeni_Click);
      // 
      // label7
      // 
      this.label7.AutoSize = true;
      this.label7.BackColor = System.Drawing.Color.Transparent;
      this.label7.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
      this.label7.ForeColor = System.Drawing.Color.LightSeaGreen;
      this.label7.Location = new System.Drawing.Point(440, 80);
      this.label7.Name = "label7";
      this.label7.Size = new System.Drawing.Size(124, 18);
      this.label7.TabIndex = 104;
      this.label7.Text = "Damage Condition";
      // 
      // pictureBox10
      // 
      this.pictureBox10.BackColor = System.Drawing.Color.Gray;
      this.pictureBox10.Location = new System.Drawing.Point(443, 134);
      this.pictureBox10.Name = "pictureBox10";
      this.pictureBox10.Size = new System.Drawing.Size(150, 2);
      this.pictureBox10.TabIndex = 103;
      this.pictureBox10.TabStop = false;
      // 
      // cmbKitapTuru
      // 
      this.cmbKitapTuru.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.cmbKitapTuru.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
      this.cmbKitapTuru.FormattingEnabled = true;
      this.cmbKitapTuru.Items.AddRange(new object[] {
            "Action and Adventure",
            "Adventure",
            "Adventure / Horror",
            "Advertising",
            "Aesthetics and Philosophy of Art",
            "Anecdote",
            "Animal Kingdom",
            "Anthology",
            "Anthropology",
            "Aphorisms",
            "Application Works",
            "Archaeology",
            "Archaeology and Antiquity",
            "Arithmetic, Algebra, Geometry",
            "Armenian Question",
            "Army-Police-Intelligence Organization",
            "Art",
            "Art - Cinema",
            "Art - History",
            "Art - Painting",
            "Art - Photography",
            "Art - Theater",
            "Art and Architecture",
            "Art and Architecture: Calligraphy",
            "Art and Architecture: Marbling",
            "Art and Architecture: Miniature",
            "Art and Architecture: Tezhib",
            "Art History",
            "Art-Painting-Painters",
            "Astrology",
            "Astronomy and Earth Sciences",
            "Atatürk",
            "Atlases, Plans, Guide",
            "Autobiography",
            "Banking",
            "Beautiful-Concise Words",
            "Biography",
            "Biography and Memoir",
            "Biography/Autobiography",
            "Business Administration, Management",
            "Business World",
            "Business World-Career",
            "Career and Leadership",
            "Carpet, Rug and Weaving",
            "Cartoon",
            "Catalog-Bibliography",
            "Central Asian Turkish History",
            "Chess, Bridge, Game",
            "Child and Adolescent Development",
            "Child Development",
            "Child Education",
            "Child Education/After-School",
            "Child Education/Preschool",
            "Child Psychology",
            "Children's Books",
            "Children's Literature",
            "City / Environment / Tourism",
            "City, Local Government",
            "Classic Detective Novels",
            "Classical Turkish Literature",
            "Collective",
            "Comics",
            "Communication",
            "Compilation",
            "Computer",
            "Contemporary Classics",
            "Crime Thriller",
            "Criminal Law",
            "Criticism",
            "Culture",
            "Culture and Art",
            "Culture and Art - Album",
            "Culture, Arts-Architecture",
            "Cultural History",
            "Democracy",
            "Detective - Adventure",
            "Detective / Novel",
            "Detective-Espionage",
            "Detective Fiction",
            "Diary-Diary",
            "Discoveries and Inventions",
            "Divan Literature",
            "Document/Review",
            "Documentary",
            "Domestic Policy",
            "Ecology",
            "Economic Policies",
            "Economic Theories",
            "Economic Thoughts",
            "Economy",
            "Economy and Finance",
            "Economy-Labor-Business World",
            "Education",
            "Education - Education Science",
            "Education - KPDS-ÜDS",
            "Education > Language Education",
            "Education and Textbooks",
            "Emotional Disorders",
            "Encyclopedia",
            "Entertainment",
            "Entertainment-Humor",
            "Environment and Ecology",
            "Essay",
            "Ethics (Moral Philosophy)",
            "Ethnic Groups",
            "European History",
            "Fairy Tale",
            "Family Information",
            "Family/Human",
            "Family/Human - Woman",
            "Fantastic",
            "Fantastic Novel",
            "Fear",
            "Fine Arts",
            "Folk Literature",
            "Folklore and Traditions",
            "Foreign Policy/International",
            "Fortune / Dream / Astrology",
            "Fortune-Horoscope-Magic",
            "Fruit and Horticulture",
            "Fun and Humor",
            "Game",
            "General Law",
            "General Topics",
            "Geography and Travel",
            "Globalization",
            "Grammar",
            "Guide Books",
            "Health",
            "Health/Medicine",
            "History of Modern Turkey",
            "History of Science",
            "History of the Balkans",
            "History of the Republic",
            "Hobby",
            "Hobby - Bridge-Chess",
            "Hobby - Cookbooks",
            "Hobby - Handicrafts",
            "Hobby - Photography",
            "Hobby / Care",
            "Hobby / Care-Beauty",
            "Hobby and Entertainment",
            "Hobby, Entertainment-Table Culture",
            "Hobby: Fashion and Clothing",
            "Horror-Thriller",
            "Human and Society",
            "Human Resources",
            "Humor",
            "Illustrated History",
            "Imperialism",
            "Intelligence and Espionage",
            "Interview",
            "Interview-Conversation",
            "Investigation-Research",
            "Islam",
            "Islam/Prayer-Worship",
            "Islam/Quran-Hadiths",
            "Islam/Sect-Sect",
            "Istanbul Books",
            "Journalism, Publishing",
            "Journalist Books-Article",
            "Journalist Writers",
            "Kemalism / Kemalism",
            "Landscape Architecture",
            "Language",
            "Language / Course Books",
            "Language/Etymology",
            "Law",
            "Legends/Epics",
            "Letter",
            "Literature",
            "Literature (Short Story - Novel)",
            "Literature of Other Languages",
            "Literature Review",
            "Literature: Ottoman Divan Ş",
            "Literature: Turkish Poetry",
            "Logic",
            "Love / Novel",
            "Love Poems",
            "Love and Romance",
            "Magic, Mystery and Prophecy",
            "Male-female relations",
            "Marxism / Left",
            "Maxims",
            "Media and Communication",
            "Meditation/Yoga",
            "Memoir",
            "Memoir and Review",
            "Memoir and Travelogue",
            "Memoir, Letter, Music",
            "Memoir-Diary-Letter",
            "Memoir/Trip",
            "Memoirs and Biographies",
            "Metaphysics-Ufo and Space",
            "Military Science",
            "Military Service and Army",
            "Minorities and Ethnic Group",
            "Modern Turkey and Atatürk",
            "Morality",
            "Music",
            "Museum - Exhibition - Biennial",
            "Mythological Tales",
            "Mythology",
            "Narrative",
            "Natural Sciences",
            "News, Media",
            "Novel",
            "Occultism",
            "Office and Management",
            "On Art and Architecture",
            "Other",
            "Ottoman Divan Poetry",
            "Ottoman History",
            "Parapsychology",
            "Periodicals",
            "Performing Arts",
            "Personal Development",
            "Philosophy",
            "Philosophy and Psychology",
            "Philosophy of Law",
            "Philosophy-Thought",
            "Photography",
            "Physics, Chemical Sciences",
            "Plant Kingdom",
            "Politics",
            "Politics - Political History",
            "Politics - Political Writings",
            "Politics - State Administration",
            "Politics-Domestic Policy",
            "Politics-Political Ideology",
            "Politics-Political Parties",
            "Politics-Revolution-Revolution",
            "Politics-Secularism-Sharia",
            "Politics-Social Policy",
            "Politics-State Management",
            "Politics-Politics",
            "Popular Culture",
            "Popular Science",
            "Postmodernism",
            "Preschool Education",
            "Press Publication Date",
            "Professional-Reference",
            "Psychology",
            "Psychology - Behavioral Science",
            "Psychology - Communication",
            "Psychology - Motivation",
            "Psychology - Psychoanalysis",
            "Psychology - Psychiatry",
            "Psychology > Review",
            "Psychology and Pedagogy",
            "Psychology-Approaches",
            "Psychology-Personality and Intelligence",
            "Psychology-Thought",
            "Psychoanalysis",
            "Public Relations",
            "Religion",
            "Religion / Buddhism",
            "Religion / Christianity",
            "Religion / Islam",
            "Religion / Research",
            "Religion-Islam",
            "Religion-Metaphysics-Psychology",
            "Religion: History of Islam",
            "Religion: Islamic Fiqh (Law)",
            "Religion: Islamic Sects",
            "Religion: Islam-Sufism",
            "Religion: Quran and Hadith",
            "Republican Period Story",
            "Research",
            "Reviews, Criticisms",
            "Revolution/Revolution",
            "Russian and Slavic Languages Edb.",
            "Sahhaf",
            "Satire and Humor",
            "Scenario-Cinema",
            "Scenario/Play",
            "Science",
            "Science - Astronomy",
            "Science - Geology - Earthquake",
            "Science - Popular science",
            "Science - Technology",
            "Science Fiction",
            "Science-Biology and Genetics",
            "Science-Technique",
            "Science/Ecology",
            "Secret Societies",
            "Secularism-Sharia",
            "Sexuality",
            "Sexuality and Reproductive Ethics",
            "Skepticism",
            "Souvenir",
            "State/Army",
            "Story",
            "Supernatural-Mystery",
            "Tale and Anecdote",
            "Tension and Horror",
            "Theories of Psychology",
            "Theory of Knowledge/Epistemology",
            "Thinkers",
            "Thought",
            "Translated Poems",
            "Travel-Comment",
            "Unspecified",
            "Western Painting Art",
            "Woman",
            "World Classics",
            "World Literature-Social",
            "World Politics",
            "World Religions",
            "Youth Books",
            "Youth Literature",
            "Youth-Adventure"});
      this.cmbKitapTuru.Location = new System.Drawing.Point(243, 104);
      this.cmbKitapTuru.MaximumSize = new System.Drawing.Size(150, 0);
      this.cmbKitapTuru.MinimumSize = new System.Drawing.Size(150, 0);
      this.cmbKitapTuru.Name = "cmbKitapTuru";
      this.cmbKitapTuru.Size = new System.Drawing.Size(150, 26);
      this.cmbKitapTuru.TabIndex = 102;
      // 
      // cmbTarih
      // 
      this.cmbTarih.CalendarMonthBackground = System.Drawing.SystemColors.Control;
      this.cmbTarih.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
      this.cmbTarih.Format = System.Windows.Forms.DateTimePickerFormat.Short;
      this.cmbTarih.Location = new System.Drawing.Point(243, 174);
      this.cmbTarih.MaximumSize = new System.Drawing.Size(150, 28);
      this.cmbTarih.MinimumSize = new System.Drawing.Size(150, 28);
      this.cmbTarih.Name = "cmbTarih";
      this.cmbTarih.Size = new System.Drawing.Size(150, 28);
      this.cmbTarih.TabIndex = 101;
      // 
      // btnGuncelle
      // 
      this.btnGuncelle.Image = ((System.Drawing.Image)(resources.GetObject("btnGuncelle.Image")));
      this.btnGuncelle.Location = new System.Drawing.Point(239, 213);
      this.btnGuncelle.Name = "btnGuncelle";
      this.btnGuncelle.Size = new System.Drawing.Size(122, 50);
      this.btnGuncelle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
      this.btnGuncelle.TabIndex = 100;
      this.btnGuncelle.TabStop = false;
      this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
      // 
      // btnSil
      // 
      this.btnSil.Image = ((System.Drawing.Image)(resources.GetObject("btnSil.Image")));
      this.btnSil.Location = new System.Drawing.Point(116, 213);
      this.btnSil.Name = "btnSil";
      this.btnSil.Size = new System.Drawing.Size(117, 50);
      this.btnSil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
      this.btnSil.TabIndex = 99;
      this.btnSil.TabStop = false;
      this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
      // 
      // btnEkle
      // 
      this.btnEkle.Image = ((System.Drawing.Image)(resources.GetObject("btnEkle.Image")));
      this.btnEkle.Location = new System.Drawing.Point(110, 213);
      this.btnEkle.Name = "btnEkle";
      this.btnEkle.Size = new System.Drawing.Size(135, 50);
      this.btnEkle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
      this.btnEkle.TabIndex = 98;
      this.btnEkle.TabStop = false;
      this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
      // 
      // label8
      // 
      this.label8.AutoSize = true;
      this.label8.BackColor = System.Drawing.Color.Transparent;
      this.label8.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
      this.label8.ForeColor = System.Drawing.Color.LightSeaGreen;
      this.label8.Location = new System.Drawing.Point(440, 9);
      this.label8.Name = "label8";
      this.label8.Size = new System.Drawing.Size(98, 18);
      this.label8.TabIndex = 97;
      this.label8.Text = "Stock Number";
      // 
      // pictureBox7
      // 
      this.pictureBox7.BackColor = System.Drawing.Color.Gray;
      this.pictureBox7.Location = new System.Drawing.Point(443, 63);
      this.pictureBox7.Name = "pictureBox7";
      this.pictureBox7.Size = new System.Drawing.Size(150, 2);
      this.pictureBox7.TabIndex = 96;
      this.pictureBox7.TabStop = false;
      // 
      // txtStok
      // 
      this.txtStok.BackColor = System.Drawing.Color.White;
      this.txtStok.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.txtStok.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
      this.txtStok.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
      this.txtStok.Location = new System.Drawing.Point(443, 30);
      this.txtStok.Name = "txtStok";
      this.txtStok.Size = new System.Drawing.Size(150, 28);
      this.txtStok.TabIndex = 95;
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.BackColor = System.Drawing.Color.Transparent;
      this.label5.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
      this.label5.ForeColor = System.Drawing.Color.LightSeaGreen;
      this.label5.Location = new System.Drawing.Point(240, 151);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(106, 18);
      this.label5.TabIndex = 94;
      this.label5.Text = "Date";
      // 
      // pictureBox4
      // 
      this.pictureBox4.BackColor = System.Drawing.Color.Gray;
      this.pictureBox4.Location = new System.Drawing.Point(243, 205);
      this.pictureBox4.Name = "pictureBox4";
      this.pictureBox4.Size = new System.Drawing.Size(150, 2);
      this.pictureBox4.TabIndex = 93;
      this.pictureBox4.TabStop = false;
      // 
      // label6
      // 
      this.label6.AutoSize = true;
      this.label6.BackColor = System.Drawing.Color.Transparent;
      this.label6.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
      this.label6.ForeColor = System.Drawing.Color.LightSeaGreen;
      this.label6.Location = new System.Drawing.Point(240, 80);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(93, 18);
      this.label6.TabIndex = 92;
      this.label6.Text = "Book Type";
      // 
      // pictureBox5
      // 
      this.pictureBox5.BackColor = System.Drawing.Color.Gray;
      this.pictureBox5.Location = new System.Drawing.Point(243, 134);
      this.pictureBox5.Name = "pictureBox5";
      this.pictureBox5.Size = new System.Drawing.Size(150, 2);
      this.pictureBox5.TabIndex = 91;
      this.pictureBox5.TabStop = false;
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.BackColor = System.Drawing.Color.Transparent;
      this.label3.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
      this.label3.ForeColor = System.Drawing.Color.LightSeaGreen;
      this.label3.Location = new System.Drawing.Point(240, 9);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(82, 18);
      this.label3.TabIndex = 90;
      this.label3.Text = "Publisher";
      // 
      // pictureBox2
      // 
      this.pictureBox2.BackColor = System.Drawing.Color.Gray;
      this.pictureBox2.Location = new System.Drawing.Point(243, 63);
      this.pictureBox2.Name = "pictureBox2";
      this.pictureBox2.Size = new System.Drawing.Size(150, 2);
      this.pictureBox2.TabIndex = 89;
      this.pictureBox2.TabStop = false;
      // 
      // txtYayinEvi
      // 
      this.txtYayinEvi.BackColor = System.Drawing.Color.White;
      this.txtYayinEvi.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.txtYayinEvi.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
      this.txtYayinEvi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
      this.txtYayinEvi.Location = new System.Drawing.Point(243, 30);
      this.txtYayinEvi.Name = "txtYayinEvi";
      this.txtYayinEvi.Size = new System.Drawing.Size(150, 28);
      this.txtYayinEvi.TabIndex = 88;
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.BackColor = System.Drawing.Color.Transparent;
      this.label4.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
      this.label4.ForeColor = System.Drawing.Color.LightSeaGreen;
      this.label4.Location = new System.Drawing.Point(11, 149);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(85, 18);
      this.label4.TabIndex = 87;
      this.label4.Text = "Author Name";
      // 
      // pictureBox3
      // 
      this.pictureBox3.BackColor = System.Drawing.Color.Gray;
      this.pictureBox3.Location = new System.Drawing.Point(14, 203);
      this.pictureBox3.Name = "pictureBox3";
      this.pictureBox3.Size = new System.Drawing.Size(150, 2);
      this.pictureBox3.TabIndex = 86;
      this.pictureBox3.TabStop = false;
      // 
      // txtYazar
      // 
      this.txtYazar.BackColor = System.Drawing.Color.White;
      this.txtYazar.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.txtYazar.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
      this.txtYazar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
      this.txtYazar.Location = new System.Drawing.Point(14, 170);
      this.txtYazar.Name = "txtYazar";
      this.txtYazar.Size = new System.Drawing.Size(150, 28);
      this.txtYazar.TabIndex = 85;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.BackColor = System.Drawing.Color.Transparent;
      this.label2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
      this.label2.ForeColor = System.Drawing.Color.LightSeaGreen;
      this.label2.Location = new System.Drawing.Point(11, 80);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(83, 18);
      this.label2.TabIndex = 84;
      this.label2.Text = "Book Name";
      // 
      // pictureBox1
      // 
      this.pictureBox1.BackColor = System.Drawing.Color.Gray;
      this.pictureBox1.Location = new System.Drawing.Point(14, 134);
      this.pictureBox1.Name = "pictureBox1";
      this.pictureBox1.Size = new System.Drawing.Size(150, 2);
      this.pictureBox1.TabIndex = 83;
      this.pictureBox1.TabStop = false;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.BackColor = System.Drawing.Color.Transparent;
      this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
      this.label1.ForeColor = System.Drawing.Color.LightSeaGreen;
      this.label1.Location = new System.Drawing.Point(11, 9);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(110, 18);
      this.label1.TabIndex = 82;
      this.label1.Text = "Barcode Number";
      // 
      // nameAnim
      // 
      this.nameAnim.BackColor = System.Drawing.Color.Gray;
      this.nameAnim.Location = new System.Drawing.Point(14, 63);
      this.nameAnim.Name = "nameAnim";
      this.nameAnim.Size = new System.Drawing.Size(150, 2);
      this.nameAnim.TabIndex = 81;
      this.nameAnim.TabStop = false;
      // 
      // txtBarkod
      // 
      this.txtBarkod.BackColor = System.Drawing.SystemColors.Window;
      this.txtBarkod.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.txtBarkod.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
      this.txtBarkod.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
      this.txtBarkod.Location = new System.Drawing.Point(14, 30);
      this.txtBarkod.Name = "txtBarkod";
      this.txtBarkod.Size = new System.Drawing.Size(150, 28);
      this.txtBarkod.TabIndex = 80;
      // 
      // rTur
      // 
      this.rTur.AutoSize = true;
      this.rTur.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
      this.rTur.ForeColor = System.Drawing.Color.DarkMagenta;
      this.rTur.Location = new System.Drawing.Point(497, 352);
      this.rTur.Name = "rTur";
      this.rTur.Size = new System.Drawing.Size(136, 19);
      this.rTur.TabIndex = 186;
      this.rTur.TabStop = true;
      this.rTur.Text = "Search by Book Type";
      this.rTur.UseVisualStyleBackColor = true;
      // 
      // rBarkod
      // 
      this.rBarkod.AutoSize = true;
      this.rBarkod.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
      this.rBarkod.ForeColor = System.Drawing.Color.DarkMagenta;
      this.rBarkod.Location = new System.Drawing.Point(497, 299);
      this.rBarkod.Name = "rBarkod";
      this.rBarkod.Size = new System.Drawing.Size(119, 19);
      this.rBarkod.TabIndex = 185;
      this.rBarkod.TabStop = true;
      this.rBarkod.Text = "Search by Barcode";
      this.rBarkod.UseVisualStyleBackColor = true;
      // 
      // rKitap
      // 
      this.rKitap.AutoSize = true;
      this.rKitap.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
      this.rKitap.ForeColor = System.Drawing.Color.DarkMagenta;
      this.rKitap.Location = new System.Drawing.Point(497, 325);
      this.rKitap.Name = "rKitap";
      this.rKitap.Size = new System.Drawing.Size(128, 19);
      this.rKitap.TabIndex = 184;
      this.rKitap.TabStop = true;
      this.rKitap.Text = "Search by Book Name";
      this.rKitap.UseVisualStyleBackColor = true;
      // 
      // label11
      // 
      this.label11.AutoSize = true;
      this.label11.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
      this.label11.ForeColor = System.Drawing.Color.DarkCyan;
      this.label11.Location = new System.Drawing.Point(496, 380);
      this.label11.Name = "label11";
      this.label11.Size = new System.Drawing.Size(130, 18);
      this.label11.TabIndex = 183;
      this.label11.Text = "Search for Word";
      // 
      // txtAra
      // 
      this.txtAra.BackColor = System.Drawing.Color.White;
      this.txtAra.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.txtAra.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
      this.txtAra.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
      this.txtAra.Location = new System.Drawing.Point(499, 401);
      this.txtAra.Name = "txtAra";
      this.txtAra.Size = new System.Drawing.Size(125, 28);
      this.txtAra.TabIndex = 182;
      this.txtAra.TextChanged += new System.EventHandler(this.txtAra_TextChanged);
      // 
      // pictureBox8
      // 
      this.pictureBox8.BackColor = System.Drawing.Color.Gray;
      this.pictureBox8.Location = new System.Drawing.Point(499, 431);
      this.pictureBox8.Name = "pictureBox8";
      this.pictureBox8.Size = new System.Drawing.Size(125, 2);
      this.pictureBox8.TabIndex = 181;
      this.pictureBox8.TabStop = false;
      // 
      // dtKitaplar
      // 
      this.dtKitaplar.AllowUserToAddRows = false;
      this.dtKitaplar.AllowUserToDeleteRows = false;
      this.dtKitaplar.BackgroundColor = System.Drawing.SystemColors.Control;
      this.dtKitaplar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dtKitaplar.Location = new System.Drawing.Point(2, 271);
      this.dtKitaplar.Name = "dtKitaplar";
      this.dtKitaplar.ReadOnly = true;
      this.dtKitaplar.Size = new System.Drawing.Size(491, 189);
      this.dtKitaplar.TabIndex = 180;
      // 
      // cmbKitapAdi
      // 
      this.cmbKitapAdi.BackColor = System.Drawing.Color.White;
      this.cmbKitapAdi.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.cmbKitapAdi.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
      this.cmbKitapAdi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
      this.cmbKitapAdi.Location = new System.Drawing.Point(14, 104);
      this.cmbKitapAdi.Name = "cmbKitapAdi";
      this.cmbKitapAdi.Size = new System.Drawing.Size(150, 28);
      this.cmbKitapAdi.TabIndex = 187;
      // 
      // kitapEkle
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.White;
      this.Controls.Add(this.cmbKitapAdi);
      this.Controls.Add(this.rTur);
      this.Controls.Add(this.rBarkod);
      this.Controls.Add(this.rKitap);
      this.Controls.Add(this.label11);
      this.Controls.Add(this.txtAra);
      this.Controls.Add(this.pictureBox8);
      this.Controls.Add(this.dtKitaplar);
      this.Controls.Add(this.btnGuncelle);
      this.Controls.Add(this.btnGetir);
      this.Controls.Add(this.cmbHasar);
      this.Controls.Add(this.label9);
      this.Controls.Add(this.btnYeni);
      this.Controls.Add(this.label7);
      this.Controls.Add(this.pictureBox10);
      this.Controls.Add(this.cmbKitapTuru);
      this.Controls.Add(this.cmbTarih);
      this.Controls.Add(this.btnSil);
      this.Controls.Add(this.btnEkle);
      this.Controls.Add(this.label8);
      this.Controls.Add(this.pictureBox7);
      this.Controls.Add(this.txtStok);
      this.Controls.Add(this.label5);
      this.Controls.Add(this.pictureBox4);
      this.Controls.Add(this.label6);
      this.Controls.Add(this.pictureBox5);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.pictureBox2);
      this.Controls.Add(this.txtYayinEvi);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.pictureBox3);
      this.Controls.Add(this.txtYazar);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.pictureBox1);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.nameAnim);
      this.Controls.Add(this.txtBarkod);
      this.Name = "kitapEkle";
      this.Size = new System.Drawing.Size(630, 465);
      this.Load += new System.EventHandler(this.kitapEkle_Load);
      ((System.ComponentModel.ISupportInitialize)(this.btnGetir)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.btnYeni)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.btnGuncelle)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.btnSil)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.btnEkle)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.nameAnim)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.dtKitaplar)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.PictureBox btnGetir;
    private System.Windows.Forms.ComboBox cmbHasar;
    private System.Windows.Forms.Label label9;
    private System.Windows.Forms.PictureBox btnYeni;
    private System.Windows.Forms.Label label7;
    private System.Windows.Forms.PictureBox pictureBox10;
    private System.Windows.Forms.ComboBox cmbKitapTuru;
    private System.Windows.Forms.DateTimePicker cmbTarih;
    private System.Windows.Forms.PictureBox btnGuncelle;
    private System.Windows.Forms.PictureBox btnSil;
    private System.Windows.Forms.PictureBox btnEkle;
    private System.Windows.Forms.Label label8;
    private System.Windows.Forms.PictureBox pictureBox7;
    private System.Windows.Forms.TextBox txtStok;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.PictureBox pictureBox4;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.PictureBox pictureBox5;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.PictureBox pictureBox2;
    private System.Windows.Forms.TextBox txtYayinEvi;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.PictureBox pictureBox3;
    private System.Windows.Forms.TextBox txtYazar;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.PictureBox pictureBox1;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.PictureBox nameAnim;
    private System.Windows.Forms.TextBox txtBarkod;
    private System.Windows.Forms.RadioButton rTur;
    private System.Windows.Forms.RadioButton rBarkod;
    private System.Windows.Forms.RadioButton rKitap;
    private System.Windows.Forms.Label label11;
    private System.Windows.Forms.TextBox txtAra;
    private System.Windows.Forms.PictureBox pictureBox8;
    public System.Windows.Forms.DataGridView dtKitaplar;
    private System.Windows.Forms.TextBox cmbKitapAdi;
  }
}
