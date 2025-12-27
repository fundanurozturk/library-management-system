DELETE FROM emanet;
DELETE FROM uyeler;
DELETE FROM kullanicilar;

DELETE FROM kitaplar;

INSERT INTO kitaplar (Barkod, KitapAdi, YazarAdi, YayinEvi, KitapTuru, Temin, StokSayisi, Hasar)
VALUES (8973,'Yeralından Notlar','Fyodor Dostoyevski','Can','Philosophy-Psychology', DateSerial(2025,12,12),20,'Undamaged');

INSERT INTO kitaplar (Barkod, KitapAdi, YazarAdi, YayinEvi, KitapTuru, Temin, StokSayisi, Hasar)
VALUES (2805,'Gregor ve Gri Kehanet','Suzanna Collins','Pegasus','Action and Adventure', DateSerial(2025,12,12),17,'Undamaged');

INSERT INTO kitaplar (Barkod, KitapAdi, YazarAdi, YayinEvi, KitapTuru, Temin, StokSayisi, Hasar)
VALUES (6236,'Atomik Alışkanlıklar','James Clear','Pegasus','Personal Development', DateSerial(2025,12,12),26,'Undamaged');

INSERT INTO kitaplar (Barkod, KitapAdi, YazarAdi, YayinEvi, KitapTuru, Temin, StokSayisi, Hasar)
VALUES (9814,'Dijital Kale','Dan Brown','Altın Kitaplar','Science Fiction', DateSerial(2025,12,12),33,'Undamaged');

INSERT INTO kitaplar (Barkod, KitapAdi, YazarAdi, YayinEvi, KitapTuru, Temin, StokSayisi, Hasar)
VALUES (3717,'Kinyas ve Kayra','Hakan Günday','İş Bankası','Action and Adventure', DateSerial(2025,12,12),20,'Undamaged');

INSERT INTO kitaplar (Barkod, KitapAdi, YazarAdi, YayinEvi, KitapTuru, Temin, StokSayisi, Hasar)
VALUES (5604,'Tutunamayanlar','Oğuz Atay','Sel','Novel', DateSerial(2025,12,12),19,'Undamaged');

INSERT INTO kitaplar (Barkod, KitapAdi, YazarAdi, YayinEvi, KitapTuru, Temin, StokSayisi, Hasar)
VALUES (4168,'Fahrenheit 451','Ray Bradbury','İthaki','Science Fiction', DateSerial(2025,12,12),40,'Undamaged');

INSERT INTO kitaplar (Barkod, KitapAdi, YazarAdi, YayinEvi, KitapTuru, Temin, StokSayisi, Hasar)
VALUES (5184,'Doğu Expresinde Cinayet','Agatha Christie','Altın Kitaplar','Crime Thriller', DateSerial(2025,12,12),16,'Undamaged');

INSERT INTO kitaplar (Barkod, KitapAdi, YazarAdi, YayinEvi, KitapTuru, Temin, StokSayisi, Hasar)
VALUES (1794,'Jane Eyre','Charlotte Brontë','Can','Novel', DateSerial(2025,12,12),1,'Damaged');

INSERT INTO kitaplar (Barkod, KitapAdi, YazarAdi, YayinEvi, KitapTuru, Temin, StokSayisi, Hasar)
VALUES (6805,'Huzursuzluğun Kitabı','Fernando Pessoa','Can','Mythology', DateSerial(2025,12,12),12,'Undamaged');

INSERT INTO kitaplar (Barkod, KitapAdi, YazarAdi, YayinEvi, KitapTuru, Temin, StokSayisi, Hasar)
VALUES (5484,'Ölmeye Yatmak','Adalet Ağaoğlu','Everest','Novel', DateSerial(2025,12,12),31,'Undamaged');

INSERT INTO kitaplar (Barkod, KitapAdi, YazarAdi, YayinEvi, KitapTuru, Temin, StokSayisi, Hasar)
VALUES (8788,'22/11/63','Stephen King','Altın Kitaplar','Science Fiction', DateSerial(2025,12,12),78,'Undamaged');

INSERT INTO kitaplar (Barkod, KitapAdi, YazarAdi, YayinEvi, KitapTuru, Temin, StokSayisi, Hasar)
VALUES (6693,'wef','fd','rge','Love Poems', DateSerial(2025,12,12),3,'Undamaged');

INSERT INTO kullanicilar (KAdi, KSifre, KHakkinda, KAdSoyad, KTel, KEposta, Yetki)
VALUES ('11560208294','funda','Ankara','Fundanur Öztürk','05531607740','fundanur@gmail.com','Admin');

INSERT INTO kullanicilar (KAdi, KSifre, KHakkinda, KAdSoyad, KTel, KEposta, Yetki)
VALUES ('21118080055','123456','Ankara','Ayşe Öz','05072302130','ayseoz@gmail.com','Admin');

INSERT INTO uyeler (Tc,Sifre,Adsoyad,Yetki,Sinif,Numara,DogumT,DogumY,Telefon,Eposta,UyelikT,Cinsiyet,Adres)
VALUES ('21118080055','123456','Ayşe Öz','Admin',1,'14412556', DateSerial(2002,5,6),'Ankara','05072302130','ayseoz@gmail.com', DateSerial(2025,12,13),'Female','Ankara');

INSERT INTO uyeler (Tc,Sifre,Adsoyad,Yetki,Sinif,Numara,DogumT,DogumY,Telefon,Eposta,UyelikT,Cinsiyet,Adres)
VALUES ('11560208294','funda','Fundanur Öztürk','Admin',2,'21118080056', DateSerial(2003,5,28),'Ankara','05531607740','fundanur@gmail.com', DateSerial(2025,12,13),'Female','Ankara');

INSERT INTO uyeler (Tc,Sifre,Adsoyad,Yetki,Sinif,Numara,DogumT,DogumY,Telefon,Eposta,UyelikT,Cinsiyet,Adres)
VALUES ('12345678909','123','Mehmet Öz','Member',3,'11111111111', DateSerial(2000,2,2),'İzmir','05555555550','deneme@gmail.com', DateSerial(2025,12,22),'Male','İzmir');

INSERT INTO uyeler (Tc,Sifre,Adsoyad,Yetki,Sinif,Numara,DogumT,DogumY,Telefon,Eposta,UyelikT,Cinsiyet,Adres)
VALUES ('98765432101','KaMelYa21','Bora Alpaslan','Member',4,'21111111111', DateSerial(1999,5,31),'İstanbul','05555555555','deneme2@gmail.com', DateSerial(2025,12,22),'Male','İstanbul');

INSERT INTO uyeler (Tc,Sifre,Adsoyad,Yetki,Sinif,Numara,DogumT,DogumY,Telefon,Eposta,UyelikT,Cinsiyet,Adres)
VALUES ('10985637321','123','Fatma Betül Alpaslan','Member',4,'21118080084', DateSerial(1992,9,1),'Karabük','05321567892','betul@gmail.com', DateSerial(2025,12,22),'Female','Karabük');

INSERT INTO uyeler (Tc,Sifre,Adsoyad,Yetki,Sinif,Numara,DogumT,DogumY,Telefon,Eposta,UyelikT,Cinsiyet,Adres)
VALUES ('17529076453','sadi','Sadrettin Keşkeş','Member',5,'123456778', DateSerial(2003,6,1),'Elazığ','05555555555','sadi321@gmail.com', DateSerial(2025,12,13),'Male','Antalya');

INSERT INTO emanet (EmanetNo,Adsoyad,Tc,Numara,Sinif,Barkod,KitapAdi,Turu,Hasar,vTarih,tTarih,Durum)
VALUES (2001,'Ayşe Öz','21118080055','14412556',1,8973,'Yeralından Notlar','Philosophy-Psychology','Undamaged', DateSerial(2025,12,13), DateSerial(2025,12,18),'Returned');

INSERT INTO emanet (EmanetNo,Adsoyad,Tc,Numara,Sinif,Barkod,KitapAdi,Turu,Hasar,vTarih,tTarih,Durum)
VALUES (2001,'Ayşe Öz','21118080055','14412556',1,8973,'Yeralından Notlar','Philosophy-Psychology','Undamaged', DateSerial(2025,12,13), DateSerial(2025,12,18),'Returned');

INSERT INTO emanet (EmanetNo,Adsoyad,Tc,Numara,Sinif,Barkod,KitapAdi,Turu,Hasar,vTarih,tTarih,Durum)
VALUES (2002,'Mehmet Öz','11560208294','11111111111',3,6236,'Atomik Alışkanlıklar','Personal Development','Undamaged', DateSerial(2025,12,14), DateSerial(2025,12,20),'Returned');

INSERT INTO emanet (EmanetNo,Adsoyad,Tc,Numara,Sinif,Barkod,KitapAdi,Turu,Hasar,vTarih,tTarih,Durum)
VALUES (2003,'Bora Alpaslan','98765432101','21111111111',4,5184,'Doğu Expresinde Cinayet','Crime Thriller','Undamaged', DateSerial(2025,12,15), DateSerial(2025,12,23),'Borrowed');

INSERT INTO emanet (EmanetNo,Adsoyad,Tc,Numara,Sinif,Barkod,KitapAdi,Turu,Hasar,vTarih,tTarih,Durum)
VALUES (2004,'Sadrettin Keşkeş','17529076453','123456778',5,6805,'Huzursuzluğun Kitabı','Mythology','Undamaged', DateSerial(2025,12,16), DateSerial(2025,12,22),'Returned');

INSERT INTO emanet (EmanetNo,Adsoyad,Tc,Numara,Sinif,Barkod,KitapAdi,Turu,Hasar,vTarih,tTarih,Durum)
VALUES (2005,'Fatma Betül Alpaslan','10985637321','21118080084',4,8788,'22/11/63','Science Fiction','Undamaged', DateSerial(2025,12,17), DateSerial(2025,12,23),'Returned');
