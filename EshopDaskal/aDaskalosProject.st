<?xml version="1.0"?>

<st-source>
<time-stamp>From VisualWorks® Personal Use Edition, Pre-Release 8.1 (oct14.3) of 24. října 2014 on 24. dubna 2024 at 10:41:03</time-stamp>


<class>
<name>Eshop</name>
<environment>Smalltalk</environment>
<super>DaskalosDataObject</super>
<private>false</private>
<indexed-type>none</indexed-type>
<inst-vars>nazev adresa </inst-vars>
<class-inst-vars></class-inst-vars>
<imports></imports>
<category>DaskalosUserClasses</category>
<attributes>
<package>DaskalosUserClasses</package>
</attributes>
</class>

<!-- -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -   -->


<methods>
<class-id>Eshop class</class-id> <category>instance variables behavior</category>

<body package="DaskalosUserClasses" selector="instVarTypes">instVarTypes
</methods>

<!-- -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -   -->


<methods>
<class-id>Eshop</class-id> <category>accessing</category>

<body package="DaskalosUserClasses" selector="adresa">adresa

<body package="DaskalosUserClasses" selector="adresa:">adresa: t1 

<body package="DaskalosUserClasses" selector="nazev">nazev

<body package="DaskalosUserClasses" selector="nazev:">nazev: t1 
</methods>

<methods>
<class-id>Eshop</class-id> <category>instance initialization</category>

<body package="DaskalosUserClasses" selector="initialize">initialize
</methods>


<class>
<name>Objednavka</name>
<environment>Smalltalk</environment>
<super>Eshop</super>
<private>false</private>
<indexed-type>none</indexed-type>
<inst-vars>cislo objednaneProdukty </inst-vars>
<class-inst-vars></class-inst-vars>
<imports></imports>
<category>DaskalosUserClasses</category>
<attributes>
<package>DaskalosUserClasses</package>
</attributes>
</class>

<!-- -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -   -->


<methods>
<class-id>Objednavka class</class-id> <category>instance variables behavior</category>

<body package="DaskalosUserClasses" selector="instVarTypes">instVarTypes
</methods>

<!-- -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -   -->


<methods>
<class-id>Objednavka</class-id> <category>accessing</category>

<body package="DaskalosUserClasses" selector="cislo">cislo

<body package="DaskalosUserClasses" selector="cislo:">cislo: t1 

<body package="DaskalosUserClasses" selector="objednaneProdukty">objednaneProdukty

<body package="DaskalosUserClasses" selector="objednaneProdukty:">objednaneProdukty: t1 
</methods>

<methods>
<class-id>Objednavka</class-id> <category>instance initialization</category>

<body package="DaskalosUserClasses" selector="initialize">initialize
</methods>


<class>
<name>Zamestnanec</name>
<environment>Smalltalk</environment>
<super>Eshop</super>
<private>false</private>
<indexed-type>none</indexed-type>
<inst-vars>opravneni jmeno prijmeni </inst-vars>
<class-inst-vars></class-inst-vars>
<imports></imports>
<category>DaskalosUserClasses</category>
<attributes>
<package>DaskalosUserClasses</package>
</attributes>
</class>

<!-- -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -   -->


<methods>
<class-id>Zamestnanec class</class-id> <category>instance variables behavior</category>

<body package="DaskalosUserClasses" selector="instVarTypes">instVarTypes
</methods>

<!-- -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -   -->


<methods>
<class-id>Zamestnanec</class-id> <category>accessing</category>

<body package="DaskalosUserClasses" selector="jmeno">jmeno

<body package="DaskalosUserClasses" selector="jmeno:">jmeno: t1 

<body package="DaskalosUserClasses" selector="opravneni">opravneni

<body package="DaskalosUserClasses" selector="opravneni:">opravneni: t1 

<body package="DaskalosUserClasses" selector="prijmeni">prijmeni

<body package="DaskalosUserClasses" selector="prijmeni:">prijmeni: t1 
</methods>

<methods>
<class-id>Zamestnanec</class-id> <category>instance initialization</category>

<body package="DaskalosUserClasses" selector="initialize">initialize
</methods>


<class>
<name>Zakaznik</name>
<environment>Smalltalk</environment>
<super>Eshop</super>
<private>false</private>
<indexed-type>none</indexed-type>
<inst-vars>jmeno prijmeni </inst-vars>
<class-inst-vars></class-inst-vars>
<imports></imports>
<category>DaskalosUserClasses</category>
<attributes>
<package>DaskalosUserClasses</package>
</attributes>
</class>

<!-- -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -   -->


<methods>
<class-id>Zakaznik class</class-id> <category>instance variables behavior</category>

<body package="DaskalosUserClasses" selector="instVarTypes">instVarTypes
</methods>

<!-- -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -   -->


<methods>
<class-id>Zakaznik</class-id> <category>accessing</category>

<body package="DaskalosUserClasses" selector="jmeno">jmeno

<body package="DaskalosUserClasses" selector="jmeno:">jmeno: t1 

<body package="DaskalosUserClasses" selector="prijmeni">prijmeni

<body package="DaskalosUserClasses" selector="prijmeni:">prijmeni: t1 
</methods>

<methods>
<class-id>Zakaznik</class-id> <category>instance initialization</category>

<body package="DaskalosUserClasses" selector="initialize">initialize
</methods>


<class>
<name>Dopravce</name>
<environment>Smalltalk</environment>
<super>Eshop</super>
<private>false</private>
<indexed-type>none</indexed-type>
<inst-vars>dobaDoruceni cenaDopravy nazevD </inst-vars>
<class-inst-vars></class-inst-vars>
<imports></imports>
<category>DaskalosUserClasses</category>
<attributes>
<package>DaskalosUserClasses</package>
</attributes>
</class>

<!-- -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -   -->


<methods>
<class-id>Dopravce class</class-id> <category>instance variables behavior</category>

<body package="DaskalosUserClasses" selector="instVarTypes">instVarTypes
</methods>

<!-- -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -   -->


<methods>
<class-id>Dopravce</class-id> <category>accessing</category>

<body package="DaskalosUserClasses" selector="cenaDopravy">cenaDopravy

<body package="DaskalosUserClasses" selector="cenaDopravy:">cenaDopravy: t1 

<body package="DaskalosUserClasses" selector="dobaDoruceni">dobaDoruceni

<body package="DaskalosUserClasses" selector="dobaDoruceni:">dobaDoruceni: t1 

<body package="DaskalosUserClasses" selector="nazevD">nazevD

<body package="DaskalosUserClasses" selector="nazevD:">nazevD: t1 
</methods>

<methods>
<class-id>Dopravce</class-id> <category>instance initialization</category>

<body package="DaskalosUserClasses" selector="initialize">initialize
</methods>


<class>
<name>Produkt</name>
<environment>Smalltalk</environment>
<super>Eshop</super>
<private>false</private>
<indexed-type>none</indexed-type>
<inst-vars>cena popis nazevP </inst-vars>
<class-inst-vars></class-inst-vars>
<imports></imports>
<category>DaskalosUserClasses</category>
<attributes>
<package>DaskalosUserClasses</package>
</attributes>
</class>

<!-- -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -   -->


<methods>
<class-id>Produkt class</class-id> <category>instance variables behavior</category>

<body package="DaskalosUserClasses" selector="instVarTypes">instVarTypes
</methods>

<!-- -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -   -->


<methods>
<class-id>Produkt</class-id> <category>accessing</category>

<body package="DaskalosUserClasses" selector="cena">cena

<body package="DaskalosUserClasses" selector="cena:">cena: t1 

<body package="DaskalosUserClasses" selector="nazevP">nazevP

<body package="DaskalosUserClasses" selector="nazevP:">nazevP: t1 

<body package="DaskalosUserClasses" selector="popis">popis

<body package="DaskalosUserClasses" selector="popis:">popis: t1 
</methods>

<methods>
<class-id>Produkt</class-id> <category>instance initialization</category>

<body package="DaskalosUserClasses" selector="initialize">initialize
</methods>


</st-source>