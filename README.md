# RPG
// Mantošana (Inheritance)
Mantošana tiek izmantota, lai nodrošinātu kopīgu funkcionalitāti visām Character klasēm (gan Player, gan Enemy). Šis princips ļauj abiem tipiem dalīties ar kopējiem atribūtiem, piemēram, veselību, uzbrukuma spēku un iespēju uzbrukt.

Character klase satur kopējās funkcijas un īpašības, piemēram, health un Attack() metodi.

Player un Enemy klasēs tiek mantojumi no Character klases, pievienojot specifiskas funkcijas katram veidam, piemēram, spēlētāja vārds vai pretinieka agresivitāte.

Polimorfisms tiek izmantots, lai ļautu dažādiem objektiem izmantot to pašu metodi, bet ar atšķirīgu uzvedību.

Attack() metode tiek pārrakstīta Berserker klasē, lai palielinātu uzbrukuma spēku atkarībā no agresivitātes.

Weapon klase tiek pārsniegta ar BasicWeapon un PoisonedWeapon, kas izmanto atšķirīgas ietekmes uz pretinieku. ApplyEffect() funkcija tiek pārsniegta, lai pielietotu konkrētu efektu katram ierocim.

Abstrakcija tiek izmantota, lai nodrošinātu vienotu interfeisu dažādiem ierociem.

Weapon klase ir abstrakta klase, kas nosaka pamata struktūru ieroču klasēm.

BasicWeapon un PoisonedWeapon ir konkrēti ieroci, kas manto no Weapon un implementē savus īpašos uzvedības efektus, piemēram, bojājumu un saindēšanas efektus.



Papildu uzdevumu realizācija

Trīs dažādi pretinieki ar atšķirīgiem uzbrukumiem
Berserker klase, kas palielina uzbrukuma spēku, pamatojoties uz agresivitāti.
Goblin klase, kas pielieto uzbrukuma mehānismus ar īpašiem efektiem, piemēram, ātrākām uzbrukuma iespējām.
PoisonedEnemy klase, kas var izmantot saindēšanas ietekmes uz spēlētāju.

Bruņu sistēma- tiek ieviesta bruņu sistēma, kur katrs ierocis ir efektīvāks pret dažādām bruņām. Piemēram, zobens ir efektīvāks pret vieglām bruņām, bet āmurs – pret smagākām.