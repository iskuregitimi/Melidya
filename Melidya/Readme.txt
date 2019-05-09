- Bir �irketin bir tane user/password bilgisi olur
- Customers Tablosuna Password diye bir kolon eklenecek(Varchar(20) ve Null olabilir)
- Login sayfas� yap�larak login yap�lacak. Sayfada kullan�c� ad� ve �ifre alanlar� olacak
- Headerdaki login butonu kalkacak ve orada m��terinin contact name'i yazacak. 
- Order sayfas� eklenecek ve bu order sayfas�n�n linki m��teri login olduktan sonra g�r�necek. 
- Order sayfas�nda sadece login olan m��terinin orderlar� listelenecek. 
- Orderlar t�kland���nda order details sayfas� a��lacak. orderdaki �r�nler g�r�necek. 

- Profilim sayfas� eklenecek ve login olduktan sonra bu link headerda g�r�necek. 
- Profilim sayfas�ndan ki�i bilgileri g�ncellenecek. Kullan�c� ad� �ifre dahil. 

- Logout linki eklenecek. Bu logout linki login olduktan sonra g�r�necek. 
  Session i�erisi bu link t�kland���nda bo�alt�lacak. 
  Ayr�ca bu linke ait action Login controller i�erisinde olacak. 

- �r�nler sayfas� olacak. T�m �r�nler listelenecek. (Tablo �eklinde s�ralama de�il g�zelce e-ticaret sitelerindeki gibi �r�n listesi olmal�)

-----SEPET konusu konu�ulacak ----------------------------------------------------
- �r�nler sayfas�nda her �r�n�n yan�nda sepete ekle butonu olacak. 
- Header'a sepetim linki eklenecek ve bu link t�kland���nda sepetteki �r�nler g�sterilecek.
- Sepet iconunda �r�nlerin adedi g�sterilecek


-- Admin uygulamas� yap�lacak ----------------------------------------------------
- Employee ler admin olarak login olabilecek. (Password kolonu a��lacak)
- Categori listeleme- ekleme sayfalar� yap�lacak
- �r�n ekleme sayfas� yap�lacak.  (categorilere �r�nler eklenebilecek)
- Sipari� listesi sayfas� yap�lacak
  B�ylece admin kullan�c�s� sitede m��terilerin verdi�i sipari�leri g�recek.
  Bu sayfadaki liste �u �ekilde olacak "OrderId, Contact Name, OrderDate, Total Amount, Ship Address"
  (Yeni bir model olu�turman�z gerek. Total amountu hesaplatman�z gerek.Joinli bir linq querysi)

- Sipari�ler tablosuna durum kolonu eklenecek. Yeni-Onayland�-Kargoya verildi �eklinde 3 durum verilebilecek. 

- Authentication/Authorization yap�s� kurulacak. (Roller: Admin,Onayc�,Kargocu)
- Employee ler bu rollere atanabilecek. 

- Admin olan kullan�c� b�t�n i�lemleri yapabilecek
- Onayc� sadece sipari�i onaylayacak
- Kargocu sadece onaylanm�� sipari�i kargoya verildi yapabilecek. 

