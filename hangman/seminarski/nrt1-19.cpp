/*Jovana Milicevic NRT-1/19*/
/*IGRA VESALA*/
#include <stdio.h>
#include <string>
#include <string.h>
#include <conio.h>
#include <cctype>
#include <stdlib.h>
/*struktura igraca(ime i broj poena)*/
struct Igrac
{
	std::string ime;
	int br_poena;
};
/*dobrodoslica u program i uputstvo za pokretanje igrice*/
void print_welcome()
{
	printf(" ___________________________________________ \n");
	printf("|                                           |\n");
	printf("|  >>>>  DOBRO DOSLI U IGRU VESALA!!  <<<<  |\n");
	printf("|___________________________________________|\n");
	/*printf(" ___________________________________________ \n");*/
	printf("|                                           |\n");
	printf("|                                           |\n");
	printf("|                      _______________      |\n");
	printf("|                     |___________    |     |\n");
	printf("|                         {       |   |     |\n");
	printf("|                         }       |   |     |\n");
	printf("|                         {       |   |     |\n");
	printf("|                                 |   |     |\n");
	printf("|            _                    |   |     |\n");
	printf("|           (_)                   |   |     |\n");
	printf("|            |                    |   |     |\n");
	printf("|           /|\\                   |   |     |\n");
	printf("|          / | \\                  |   |     |\n");
	printf("|           / \\                   |   |     |\n");
	printf("|          /   \\                  |   |     |\n");
	printf("|         /     \\                 |   |     |\n");
	printf("|WWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWW|   |WWWWW|\n");
	printf("|                                           |\n");
	printf("|                                           |\n");
	printf("|___________________________________________|\n");

	
	printf("|                                           |\n");
	printf("|          PRITISNITE P DA ZAPOCNETE        |\n");
	printf("|                     IGRU                  |\n");
	printf("|___________________________________________|\n\n");

}
/*unos imena igraca (prvog pa drugog)*/
void unos_imena(std::string *ime)
{
	char c;
	fflush(stdin);
	c=getchar();
	while(c!='\n')
	{
		*ime+=c;
		c=getchar();
	}

}
/*pokazuje ispravnost unetog slova za pocetak rada programa*/
void start_game()
{
	char c='r';
	while(c!='p' && c!='P')
	{
	scanf("%c", &c);
		if(c=='p' || c=='P')
		{
			printf(" ___________________________________________ \n");
			printf("|                                           |\n");
			printf("|            -- IGRA JE POCELA! --          |\n");
			printf("|___________________________________________|\n");

		}
		else
		{
			printf(" ___________________________________________ \n");
			printf("|                                           |\n");
			printf("|                -- ERROR --                |\n");
			printf("|       --ZA POCETAK IGRE UKUCAJTE  --      |\n");
			printf("|                  SLOVO P                  |\n");
			printf("|___________________________________________|\n\n");
			fflush(stdin);
		}
	}
}
/*meni gde se korisnik pita koji mod zeli da igra, protiv nekoga ili protiv kompjutera*/
int broj_igraca()
{
		
	printf(" ___________________________________________ \n");
	printf("|                                           |\n");
	printf("|            -- IZABERITE MOD --            |\n");
	printf("|      -- 1 ZA IGRU PROTIV KOMPJUTERA --    |\n");
	printf("|      -- 2 ZA IGRU PROTIV PRIJATELJA --    |\n");
	printf("|___________________________________________|\n\n");
			
	char c=_getch();

	while(c!='1' && c!='2')
		c=_getch();
	_putch(c);
	if(c=='1')
		return 1;
	else
		return 2;
}
/*pitanje da li igrac zeli da zapocne novu igru ili ne*/
bool igraj_ponovo()
{
		
	printf(" ___________________________________________ \n");
	printf("|                                           |\n");
	printf("|-- DA LI ZELITE DA ZAPOCNETE NOVU IGRU? -- |\n");
	printf("|               -- 1 ZA DA --               |\n");
	printf("|               -- 2 ZA NE --               |\n");
	printf("|___________________________________________|\n\n");
			
	char c=_getch();

	while(c!='1' && c!='2')
		c=_getch();
	_putch(c);
	if(c=='1')
		return true;
	else
		return false;
}
/*pitanje da li igrac zeli da nastavi igru ili ne*/
bool nastavi_igru()
{
		
	printf(" ___________________________________________ \n");
	printf("|                                           |\n");
	printf("|   -- DA LI ZELITE DA IGRATE PONOVO? --    |\n");
	printf("|               -- 1 ZA DA --               |\n");
	printf("|               -- 2 ZA NE --               |\n");
	printf("|___________________________________________|\n\n");
			
	char c=_getch();

	while(c!='1' && c!='2')
		c=_getch();
	_putch(c);
	if(c=='1')
		return true;
	else
		return false;
}
/*unos imena igraca samo vizuelno*/
void unos_igraca(int broj, Igrac *igrac)
{
			printf("\n ___________________________________________ \n");
			printf("|                                           |\n");
			printf("|          UNESITE IME %d. IGRACA            |\n", broj);
			printf("|           (ne vise od 10 slova)           |\n");
			printf("|___________________________________________|\n\n");
			unos_imena(&(igrac->ime));
			igrac->br_poena = 0;
}
/*unos reci sakrivene zvezdicama*/
int unos_reci(std::string *rec)
{
	char c;
	c=_getch();
	rec->erase();
	while(c!='\n' && c!='\r')
	{
		if(c=='\b')
		{
			if(rec->length()>0) /*da ne bi moglo da se obrise slovo koje ne postoji*/
			{
				_putch(c);
				_putch(' ');
				_putch(c);
				rec->pop_back();
			}
		}
		else if(!islower(c) && !isupper(c)) /*dozvoljena su samo slova(velika ili mala)*/
			{
				printf("\n ___________________________________________ \n");
				printf("|                                           |\n");
				printf("|                 -- ERROR --               |\n");
				printf("|        -- DOZVOLJENA SU SAMO SLOVA --     |\n");
				printf("|___________________________________________|\n\n");
				rec->erase();
			}
		else
		{
			*rec+=c;
			_putch('*');
		}
		c=_getch();
	}
	_putch('\n');
	return rec->length(); 

}
/*prikaz igraca koji bira rec i unos njegove zeljene reci*/
void izbor_reci(std::string *rec, std::string *igrac)
{
			printf(" ___________________________________________ \n");
			printf("|                                           |\n");
			printf("|               IGRAC:   %10s         |\n", igrac->c_str());
			printf("|                UNESITE REC                |\n");
			printf("|   -- KORISCENJE SPECIJALNIH KARAKTERA --  |\n");
			printf("|            >> NIJE DOZVOLJENA! <<         |\n");
			printf("|___________________________________________|\n\n");
			int duzina_reci=unos_reci(rec);
			while(duzina_reci>15 || duzina_reci==0)
			{
				if(duzina_reci==0)
				{
					printf("\n ___________________________________________ \n");
					printf("|                                           |\n");
					printf("|                -- ERROR --                |\n");
					printf("|        -- MORATE DA UNESETE REC --        |\n");
					printf("|___________________________________________|\n\n");
				}
				else
				{
					printf("\n ___________________________________________ \n");
					printf("|                                           |\n");
					printf("|                -- ERROR --                |\n");
					printf("|    -- DOZVOLJENE SU RECI DO 15 SLOVA--    |\n");
					printf("|___________________________________________|\n\n");
				}
			
			duzina_reci=unos_reci(rec);
			}
}
/*unosenje reci iz fajla*/
void unos_reci_iz_fajla(std::string *rec, FILE *file)
{
	char c;
	fscanf_s(file,"%c",&c);
	
	while(!feof(file) && c!='\n' && c!='\r')
	{
		*rec+=c;
		fscanf_s(file,"%c",&c);
			
	}
	
}
/*ucitavanje reci iz datoteke u igri protiv kompjutera*/
void ucitavanje_reci(std::string *rec)
{
	FILE *file = fopen("reci.txt","r");
	int broj_reci;
	fscanf_s(file,"%d\n",&broj_reci);
	std::string *ucitane_reci = new std::string[broj_reci];

	for(int i=0;i<broj_reci;i++)
	{
		unos_reci_iz_fajla(&ucitane_reci[i],file);

	}
	int random_index = ((double)rand()/RAND_MAX)*broj_reci; //biranje neke reci iz datotere izabrane slucajno
	*rec = ucitane_reci[random_index];
	fclose(file);
	delete[] ucitane_reci;
}
/*provera da li su reci vec koriscene u igranju prijatelj protiv prijatelja*/
bool provera_reci(std::string *rec, std::string *ime_fajla)
{
	FILE *file = fopen(ime_fajla->c_str(),"r");
	if(file==NULL) //ukoliko fajl ne postoji pravi se nov
	{
		file = fopen(ime_fajla->c_str(),"w");
		fprintf(file,"1\n%s",rec->c_str());
		fclose(file);
		return false;
	}
	int broj_reci;
	fscanf_s(file,"%d\n",&broj_reci);
	std::string *ucitane_reci = new std::string[broj_reci+1];
	//gledanje da li je rec vec koriscena i dodavanje indeksa na pocetku koji broji broj postojecih reci
	for(int i=0;i<broj_reci;i++) 
	{
		unos_reci_iz_fajla(&ucitane_reci[i],file);
		if((rec->compare(ucitane_reci[i]))==0)
		{
			fclose(file);
			delete[] ucitane_reci;
			return true;
		}
	}
	ucitane_reci[broj_reci] = *rec;
	fclose(file);
	file = fopen(ime_fajla->c_str(),"w");
	fprintf(file,"%d",broj_reci+1);
	for(int i=0;i<broj_reci+1;i++)
	{
		fprintf(file,"\n%s",ucitane_reci[i].c_str());
	}
	fclose(file);
	delete[] ucitane_reci;
	return false;
}
/*slike za ispis pri pogadjanju slova*/
void print_pic(int lives)
{
	if(lives<0 || lives>6)
		return;
	else
	{
		switch (lives)
		{
			case 6: 
			{
				printf("|                                           |\n");
				printf("|                                           |\n");
				printf("|                                           |\n");
				printf("|              _______________              |\n");
				printf("|             |___________    |             |\n");
				printf("|                 {       |   |             |\n");
				printf("|                 }       |   |             |\n");
				printf("|                 {       |   |             |\n");
				printf("|                         |   |             |\n");
				printf("|                         |   |             |\n");
				printf("|                         |   |             |\n");
				printf("|                         |   |             |\n");
				printf("|                         |   |             |\n");
				printf("|                         |   |             |\n");
				printf("|                         |   |             |\n");
				printf("|                         |   |             |\n");
				printf("|                         |   |             |\n");
				printf("|WWWWWWWWWWWWWWWWWWWWWWWWW|   |WWWWWWWWWWWWW|\n");
				printf("|                                           |\n");
				printf("|                                           |\n");
				printf("|                                           |\n");
				printf("|___________________________________________|\n");
				break;
			}

			case 5:
			{
				printf("|                                           |\n");
				printf("|                                           |\n");
				printf("|                                           |\n");
				printf("|              _______________              |\n");
				printf("|             |___________    |             |\n");
				printf("|                 {       |   |             |\n");
				printf("|                 }       |   |             |\n");
				printf("|                _{       |   |             |\n");
				printf("|               (_)       |   |             |\n");
				printf("|                         |   |             |\n");
				printf("|                         |   |             |\n");
				printf("|                         |   |             |\n");
				printf("|                         |   |             |\n");
				printf("|                         |   |             |\n");
				printf("|                         |   |             |\n");
				printf("|                         |   |             |\n");
				printf("|                         |   |             |\n");
				printf("|WWWWWWWWWWWWWWWWWWWWWWWWW|   |WWWWWWWWWWWWW|\n");
				printf("|                                           |\n");
				printf("|                                           |\n");
				printf("|                                           |\n");
				printf("|___________________________________________|\n");
				break;
			}
			case 4:
			{
				printf("|                                           |\n");
				printf("|                                           |\n");
				printf("|                                           |\n");
				printf("|              _______________              |\n");
				printf("|             |___________    |             |\n");
				printf("|                 {       |   |             |\n");
				printf("|                 }       |   |             |\n");
				printf("|                _{       |   |             |\n");
				printf("|               (_)       |   |             |\n");
				printf("|                |        |   |             |\n");
				printf("|                |        |   |             |\n");
				printf("|                |        |   |             |\n");
				printf("|                         |   |             |\n");
				printf("|                         |   |             |\n");
				printf("|                         |   |             |\n");
				printf("|                         |   |             |\n");
				printf("|                         |   |             |\n");
				printf("|WWWWWWWWWWWWWWWWWWWWWWWWW|   |WWWWWWWWWWWWW|\n");
				printf("|                                           |\n");
				printf("|                                           |\n");
				printf("|                                           |\n");
				printf("|___________________________________________|\n");
				break;
			}
			case 3:
			{
				printf("|                                           |\n");
				printf("|                                           |\n");
				printf("|                                           |\n");
				printf("|              _______________              |\n");
				printf("|             |___________    |             |\n");
				printf("|                 {       |   |             |\n");
				printf("|                 }       |   |             |\n");
				printf("|                _{       |   |             |\n");
				printf("|               (_)       |   |             |\n");
				printf("|                |        |   |             |\n");
				printf("|                |        |   |             |\n");
				printf("|                |        |   |             |\n");
				printf("|                 \\       |   |             |\n");
				printf("|                  \\      |   |             |\n");
				printf("|                   \\     |   |             |\n");
				printf("|                         |   |             |\n");
				printf("|                         |   |             |\n");
				printf("|WWWWWWWWWWWWWWWWWWWWWWWWW|   |WWWWWWWWWWWWW|\n");
				printf("|                                           |\n");
				printf("|                                           |\n");
				printf("|                                           |\n");
				printf("|___________________________________________|\n");
				break;
			}
			case 2:
			{
				printf("|                                           |\n");
				printf("|                                           |\n");
				printf("|                                           |\n");
				printf("|              _______________              |\n");
				printf("|             |___________    |             |\n");
				printf("|                 {       |   |             |\n");
				printf("|                 }       |   |             |\n");
				printf("|                _{       |   |             |\n");
				printf("|               (_)       |   |             |\n");
				printf("|                |        |   |             |\n");
				printf("|                |        |   |             |\n");
				printf("|                |        |   |             |\n");
				printf("|               / \\       |   |             |\n");
				printf("|              /   \\      |   |             |\n");
				printf("|             /     \\     |   |             |\n");
				printf("|                         |   |             |\n");
				printf("|                         |   |             |\n");
				printf("|WWWWWWWWWWWWWWWWWWWWWWWWW|   |WWWWWWWWWWWWW|\n");
				printf("|                                           |\n");
				printf("|                                           |\n");
				printf("|                                           |\n");
				printf("|___________________________________________|\n");
				break;
			}
			case 1:
			{
				printf("|                                           |\n");
				printf("|                                           |\n");
				printf("|                                           |\n");
				printf("|              _______________              |\n");
				printf("|             |___________    |             |\n");
				printf("|                 {       |   |             |\n");
				printf("|                 }       |   |             |\n");
				printf("|                _{       |   |             |\n");
				printf("|               (_)       |   |             |\n");
				printf("|                |        |   |             |\n");
				printf("|               /|        |   |             |\n");
				printf("|              / |        |   |             |\n");
				printf("|               / \\       |   |             |\n");
				printf("|              /   \\      |   |             |\n");
				printf("|             /     \\     |   |             |\n");
				printf("|                         |   |             |\n");
				printf("|                         |   |             |\n");
				printf("|WWWWWWWWWWWWWWWWWWWWWWWWW|   |WWWWWWWWWWWWW|\n");
				printf("|                                           |\n");
				printf("|                                           |\n");
				printf("|                                           |\n");
				printf("|___________________________________________|\n");
				break;
			}
			case 0:
			{
				printf("|                                           |\n");
				printf("|                                           |\n");
				printf("|                                           |\n");
				printf("|              _______________              |\n");
				printf("|             |___________    |             |\n");
				printf("|                 {       |   |             |\n");
				printf("|                 }       |   |             |\n");
				printf("|                _{       |   |             |\n");
				printf("|               (_)       |   |             |\n");
				printf("|                |        |   |             |\n");
				printf("|               /|\\       |   |             |\n");
				printf("|              / | \\      |   |             |\n");
				printf("|               / \\       |   |             |\n");
				printf("|              /   \\      |   |             |\n");
				printf("|             /     \\     |   |             |\n");
				printf("|                         |   |             |\n");
				printf("|                         |   |             |\n");
				printf("|WWWWWWWWWWWWWWWWWWWWWWWWW|   |WWWWWWWWWWWWW|\n");
				printf("|                                           |\n");
				printf("|___________________________________________|\n");
				break;
			}
		}
	}
}
/*ispisuje koji igrac pogadja rec*/
void print_turn(std::string *igrac, int lives, std::string *pogodjena_rec)
{
			printf(" ___________________________________________ \n");
			printf("|                                           |\n");
			printf("|       POGADJA IGRAC:   %10s         |\n", igrac->c_str());
			printf("|___________________________________________|\n");
			print_pic(lives);
			for(int i=0; i< pogodjena_rec->length(); i++)
			{
				printf("%c ",pogodjena_rec->at(i));
			}
			printf("\n\n");
}
/*provera da li je veliko ili malo slovoa*/
char dohvati_slovo()
{
	char c='\n';
	while(!isupper(c) && !islower(c))
	{
	scanf("%c", &c);
		if(isupper(c) || islower(c))
		{
			return c;
		}
	}
}
/*provera da li rec postoji, ako postoji igra se nastavlja, ako ne crta se vesalo i smanjuje se zivot*/
void pogadja(Igrac *igrac, std::string *rec)
{
	int lives = 6;
	bool rec_pogodjena=false;
	std::string pogodjeno;
	for(int i=0; i< rec->length(); i++)
	{
		pogodjeno+='_';
	}
	while(lives>0 && !rec_pogodjena)
	{
		print_turn(&(igrac->ime), lives, &pogodjeno);
		char c=dohvati_slovo();
		getchar();
		bool pogodjeno_slovo=false; 
		for(int i=0; i< rec->length(); i++)
		{
			if(c==rec->at(i))
			{
				pogodjeno.at(i)=c;
				pogodjeno_slovo=true;
			}
		}
		//ukoliko je slovo promaseno gubi se zivot
		if(!pogodjeno_slovo)
			lives--;
		else
		{
			if(strcmp(rec->c_str(),pogodjeno.c_str())==0)
			{
				rec_pogodjena = true;
				igrac->br_poena += 16-rec->length(); //rec mora da bude kraca od 15 slova
			}
		}
	}
	/*provera i ispis da li je osoba pogodila rec ili ne*/
	print_turn(&(igrac->ime), lives, &pogodjeno);
	if(rec_pogodjena)
	{
				printf(" ___________________________________________ \n");
				printf("|                                           |\n");
				printf("|          >> POGODILI STE REC <<           |\n");
				printf("|___________________________________________|\n");
	}
	else
	{
				printf(" ___________________________________________ \n");
				printf("|                                           |\n");
				printf("|              >> KRAJ IGRE <<              |\n");
				printf("|___________________________________________|\n");
	}
}



int main()
{
	/*pozivi funkcija*/
	Igrac *igraci;
	std::string data_rec;
	bool igra_u_toku = true, partija_u_toku = true;
	int br_igraca;

	print_welcome();
	start_game();
	//gledanje da li je igra u toku i unutar nje da li se igra sa dva igraca ili sa jednim, da li je rec koriscena, 
	//ispis reci u datoteku koja sadrzi ime prvog igraca protiv imena drugog igraca i da li zeli da se igra nastavi ili ne
	while(igra_u_toku)
	{
		
		br_igraca = broj_igraca();
		igraci = new Igrac[br_igraca]; 
	
		for(int i=0;i<br_igraca;i++)
		{
			unos_igraca(i+1, &igraci[i]);
		}
		partija_u_toku = true;
		while(partija_u_toku)
		{
			if(br_igraca==2)
			{
				std::string ime_fajla = std::string (igraci[0].ime).append("_vs_").append(igraci[1].ime).append(".txt");
				izbor_reci(&data_rec, &(igraci[0].ime));
				while(provera_reci(&data_rec,&ime_fajla))
				{
					printf("\n ___________________________________________ \n");
					printf("|                                           |\n");
					printf("|                -- ERROR --                |\n");
					printf("|         -- REC JE VEC KORISCENA --        |\n");
					printf("|    -- MOLIM VAS IZABERITE DRUGU REC --    |\n");
					printf("|___________________________________________|\n\n");
					izbor_reci(&data_rec, &(igraci[0].ime));
				}
				pogadja(&(igraci[1]),&data_rec);
				
				izbor_reci(&data_rec, &(igraci[1].ime));
				while(provera_reci(&data_rec,&ime_fajla))
				{
					printf("\n ___________________________________________ \n");
					printf("|                                           |\n");
					printf("|                -- ERROR --                |\n");
					printf("|         -- REC JE VEC KORISCENA --        |\n");
					printf("|    -- MOLIM VAS IZABERITE DRUGU REC --    |\n");
					printf("|___________________________________________|\n\n");
					izbor_reci(&data_rec, &(igraci[1].ime));
				}
				pogadja(&(igraci[0]),&data_rec);
			}
			else
			{
				ucitavanje_reci(&data_rec);
				pogadja(&(igraci[0]),&data_rec);
			}
			partija_u_toku = nastavi_igru();
		}				
				printf("\n ___________________________________________ \n");
				printf("|                                           |\n");
				printf("|              >> KRAJ IGRE <<              |\n");
				printf("|___________________________________________|");
		for(int i=0;i<br_igraca;i++)
		{
			//ispis poena igraca
				printf("\n ___________________________________________ \n");
				printf("|                                           |\n");
				printf("|            IGRAC:   %10s            |\n",igraci[i].ime.c_str());
				printf("|            SKOR:    %10d            |\n",igraci[i].br_poena);
				printf("|___________________________________________|\n");
		}

		delete[] igraci;
		igra_u_toku = igraj_ponovo(); //da li zeli da se opet pokrene igra
	}

}

