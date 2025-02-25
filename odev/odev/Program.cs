// See https://aka.ms/new-console-template for more information
using odev;


Bmw bm = new Bmw();

bm.marka = "Bmw";
bm.vites = "Düz vites";


Porsche po = new Porsche();

po.marka = "Porsche";
po.vites = "Otomatik vites";


Mercedes me = new Mercedes();

me.marka = "Mercedes";
me.vites = "Düz vites";


Audi au = new Audi();

au.marka = "Audi";
au.vites = "Otomatik vites";


Togg to = new Togg();

to.marka = "Togg";
to.vites = "Otomatik vites";


Toyota ty = new Toyota();

ty.marka = "Toyota";
ty.vites = "Düz vites";


bm.markaVitesYaz(bm.marka, bm.vites);
po.markaVitesYaz(po.marka, po.vites);
me.markaVitesYaz(me.marka, me.vites);
to.markaVitesYaz(to.marka, to.vites);
au.markaVitesYaz(au.marka, au.vites);
ty.markaVitesYaz(ty.marka, ty.vites);
