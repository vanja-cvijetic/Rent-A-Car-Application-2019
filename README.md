# Rent-A-Car-App-2019
Aplikacija koja predstavlja pojednostavljen sistem za iznajmljivanje automobila. (Visual Studio 2017)
<hr>

Svi podaci se čuvaju u datotekama (.bin).

Obezbeđene odgovarajuće provere pri unosu podataka.
<hr>
Aplikacija se sastoji iz dva dela, a korisnik na početku bira željeni deo:
<hr>

<h5>Administrativni deo:</h5>

<h6>Klase</h6>

Postoji klasa Korisnik koja ima odgovarajuće atribute  i metode. Administrator i Kupac nasleđuju Korisnika. 


<i>Automobil</i> (jedinstveni celobrojni identifikator, marka, model, godište, kubikaža, pogon, vrsta menjača, karoserija, gorivo, br. vrata)


<i>Kupac</i> (jedinstveni celobrojni identifikator, ime, prezime, jmbg, datum rođenja, telefon) 


<i>Ponuda</i> (jedinstveni celobrojni identifikator automobila,datum od, datum do, cena po danu)


<i>Rezervacije</i> (jedinstveni celobrojni identifikator automobila, jedinstveni celobrojni identifikator kupca, datum od, datum do, cena) 

<br>
<br>

Postoji statistika automobila po mesecu - brojčano i procentualno koristeći crtanje prikazuje se statistika odabranog meseca. 


Deo vezan za Rezervacije se menja tako što se prvo izabere kupac iz padajućeg menija i prikažu sve njegove rezervacije. 


Delovi vezani za ažuriranje sadrže upis, izmenu i brisanje za izabranu kategoriju. 

<hr>
<h5>Kupac:</h5>

Nakon prijave, kupcu se prikazuje forma koja sadrži njegove trenutne rezervacije sa opcijom da se rezervacija ukine. 

Pored toga postoji dugme koje kupca šalje na novu formu za rezervaciju željenog automobila.

Nakon uspešne rezervacije, Kupac se preusmerava na početnu formu aplikacije za kupca.

<br>
<br>

Pri pokretanju aplikacije za rezervaciju popunjava se combobox  za marku automobila. 
Na odabir marke popunjava se model. Ovi podaci se popunjavaju po unesenim podacima koji se nalaze u datoteci. 
Ostali podaci se popunjavaju na isti način. U slučaju da postoje dva automobila istog tipa a npr različitog godišta pri odabiru odgovarajućeg godišta popunjavaju se ostali podaci. 
