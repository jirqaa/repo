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

<body package="DaskalosUserClasses" selector="instVarTypes">instVarTypes	"	***This is decompiled code.*** 	No source was available"	^(Core.Dictionary new) add: #adresa -&gt; Core.String; add: #nazev -&gt; Core.String; yourself</body>
</methods>

<!-- -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -   -->


<methods>
<class-id>Eshop</class-id> <category>accessing</category>

<body package="DaskalosUserClasses" selector="adresa">adresa	"	***This is decompiled code.*** 	No source was available"	^adresa</body>

<body package="DaskalosUserClasses" selector="adresa:">adresa: t1 	"	***This is decompiled code.*** 	No source was available"	adresa := self checkValue: t1 forVariable: #adresa.	^self</body>

<body package="DaskalosUserClasses" selector="nazev">nazev	"	***This is decompiled code.*** 	No source was available"	^nazev</body>

<body package="DaskalosUserClasses" selector="nazev:">nazev: t1 	"	***This is decompiled code.*** 	No source was available"	nazev := self checkValue: t1 forVariable: #nazev.	^self</body>
</methods>

<methods>
<class-id>Eshop</class-id> <category>instance initialization</category>

<body package="DaskalosUserClasses" selector="initialize">initialize	"	***This is decompiled code.*** 	No source was available"	super initialize.	nazev := nil.	adresa := nil.	^self</body>
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

<body package="DaskalosUserClasses" selector="instVarTypes">instVarTypes	"	***This is decompiled code.*** 	No source was available"	^(Core.Dictionary new) add: #cislo -&gt; Core.Number; add: #objednaneProdukty -&gt; Core.String; yourself</body>
</methods>

<!-- -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -   -->


<methods>
<class-id>Objednavka</class-id> <category>accessing</category>

<body package="DaskalosUserClasses" selector="cislo">cislo	"	***This is decompiled code.*** 	No source was available"	^cislo</body>

<body package="DaskalosUserClasses" selector="cislo:">cislo: t1 	"	***This is decompiled code.*** 	No source was available"	cislo := self checkValue: t1 forVariable: #cislo.	^self</body>

<body package="DaskalosUserClasses" selector="objednaneProdukty">objednaneProdukty	"	***This is decompiled code.*** 	No source was available"	^objednaneProdukty</body>

<body package="DaskalosUserClasses" selector="objednaneProdukty:">objednaneProdukty: t1 	"	***This is decompiled code.*** 	No source was available"	objednaneProdukty := self checkValue: t1 forVariable: #objednaneProdukty.	^self</body>
</methods>

<methods>
<class-id>Objednavka</class-id> <category>instance initialization</category>

<body package="DaskalosUserClasses" selector="initialize">initialize	"	***This is decompiled code.*** 	No source was available"	super initialize.	cislo := nil.	objednaneProdukty := nil.	^self</body>
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

<body package="DaskalosUserClasses" selector="instVarTypes">instVarTypes	"	***This is decompiled code.*** 	No source was available"	^(Core.Dictionary new) add: #opravneni -&gt; Core.String; add: #jmeno -&gt; Core.String; add: #prijmeni -&gt; Core.String; yourself</body>
</methods>

<!-- -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -   -->


<methods>
<class-id>Zamestnanec</class-id> <category>accessing</category>

<body package="DaskalosUserClasses" selector="jmeno">jmeno	"	***This is decompiled code.*** 	No source was available"	^jmeno</body>

<body package="DaskalosUserClasses" selector="jmeno:">jmeno: t1 	"	***This is decompiled code.*** 	No source was available"	jmeno := self checkValue: t1 forVariable: #jmeno.	^self</body>

<body package="DaskalosUserClasses" selector="opravneni">opravneni	"	***This is decompiled code.*** 	No source was available"	^opravneni</body>

<body package="DaskalosUserClasses" selector="opravneni:">opravneni: t1 	"	***This is decompiled code.*** 	No source was available"	opravneni := self checkValue: t1 forVariable: #opravneni.	^self</body>

<body package="DaskalosUserClasses" selector="prijmeni">prijmeni	"	***This is decompiled code.*** 	No source was available"	^prijmeni</body>

<body package="DaskalosUserClasses" selector="prijmeni:">prijmeni: t1 	"	***This is decompiled code.*** 	No source was available"	prijmeni := self checkValue: t1 forVariable: #prijmeni.	^self</body>
</methods>

<methods>
<class-id>Zamestnanec</class-id> <category>instance initialization</category>

<body package="DaskalosUserClasses" selector="initialize">initialize	"	***This is decompiled code.*** 	No source was available"	super initialize.	opravneni := nil.	jmeno := nil.	prijmeni := nil.	^self</body>
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

<body package="DaskalosUserClasses" selector="instVarTypes">instVarTypes	"	***This is decompiled code.*** 	No source was available"	^(Core.Dictionary new) add: #prijmeni -&gt; Core.String; add: #jmeno -&gt; Core.String; yourself</body>
</methods>

<!-- -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -   -->


<methods>
<class-id>Zakaznik</class-id> <category>accessing</category>

<body package="DaskalosUserClasses" selector="jmeno">jmeno	"	***This is decompiled code.*** 	No source was available"	^jmeno</body>

<body package="DaskalosUserClasses" selector="jmeno:">jmeno: t1 	"	***This is decompiled code.*** 	No source was available"	jmeno := self checkValue: t1 forVariable: #jmeno.	^self</body>

<body package="DaskalosUserClasses" selector="prijmeni">prijmeni	"	***This is decompiled code.*** 	No source was available"	^prijmeni</body>

<body package="DaskalosUserClasses" selector="prijmeni:">prijmeni: t1 	"	***This is decompiled code.*** 	No source was available"	prijmeni := self checkValue: t1 forVariable: #prijmeni.	^self</body>
</methods>

<methods>
<class-id>Zakaznik</class-id> <category>instance initialization</category>

<body package="DaskalosUserClasses" selector="initialize">initialize	"	***This is decompiled code.*** 	No source was available"	super initialize.	jmeno := nil.	prijmeni := nil.	^self</body>
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

<body package="DaskalosUserClasses" selector="instVarTypes">instVarTypes	"	***This is decompiled code.*** 	No source was available"	^(Core.Dictionary new) add: #dobaDoruceni -&gt; Core.String; add: #cenaDopravy -&gt; Core.Number; add: #nazevD -&gt; Core.String; yourself</body>
</methods>

<!-- -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -   -->


<methods>
<class-id>Dopravce</class-id> <category>accessing</category>

<body package="DaskalosUserClasses" selector="cenaDopravy">cenaDopravy	"	***This is decompiled code.*** 	No source was available"	^cenaDopravy</body>

<body package="DaskalosUserClasses" selector="cenaDopravy:">cenaDopravy: t1 	"	***This is decompiled code.*** 	No source was available"	cenaDopravy := self checkValue: t1 forVariable: #cenaDopravy.	^self</body>

<body package="DaskalosUserClasses" selector="dobaDoruceni">dobaDoruceni	"	***This is decompiled code.*** 	No source was available"	^dobaDoruceni</body>

<body package="DaskalosUserClasses" selector="dobaDoruceni:">dobaDoruceni: t1 	"	***This is decompiled code.*** 	No source was available"	dobaDoruceni := self checkValue: t1 forVariable: #dobaDoruceni.	^self</body>

<body package="DaskalosUserClasses" selector="nazevD">nazevD	"	***This is decompiled code.*** 	No source was available"	^nazevD</body>

<body package="DaskalosUserClasses" selector="nazevD:">nazevD: t1 	"	***This is decompiled code.*** 	No source was available"	nazevD := self checkValue: t1 forVariable: #nazevD.	^self</body>
</methods>

<methods>
<class-id>Dopravce</class-id> <category>instance initialization</category>

<body package="DaskalosUserClasses" selector="initialize">initialize	"	***This is decompiled code.*** 	No source was available"	super initialize.	dobaDoruceni := nil.	cenaDopravy := nil.	nazevD := nil.	^self</body>
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

<body package="DaskalosUserClasses" selector="instVarTypes">instVarTypes	"	***This is decompiled code.*** 	No source was available"	^(Core.Dictionary new) add: #nazevP -&gt; Core.String; add: #cena -&gt; Core.Number; add: #popis -&gt; Core.String; yourself</body>
</methods>

<!-- -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -   -->


<methods>
<class-id>Produkt</class-id> <category>accessing</category>

<body package="DaskalosUserClasses" selector="cena">cena	"	***This is decompiled code.*** 	No source was available"	^cena</body>

<body package="DaskalosUserClasses" selector="cena:">cena: t1 	"	***This is decompiled code.*** 	No source was available"	cena := self checkValue: t1 forVariable: #cena.	^self</body>

<body package="DaskalosUserClasses" selector="nazevP">nazevP	"	***This is decompiled code.*** 	No source was available"	^nazevP</body>

<body package="DaskalosUserClasses" selector="nazevP:">nazevP: t1 	"	***This is decompiled code.*** 	No source was available"	nazevP := self checkValue: t1 forVariable: #nazevP.	^self</body>

<body package="DaskalosUserClasses" selector="popis">popis	"	***This is decompiled code.*** 	No source was available"	^popis</body>

<body package="DaskalosUserClasses" selector="popis:">popis: t1 	"	***This is decompiled code.*** 	No source was available"	popis := self checkValue: t1 forVariable: #popis.	^self</body>
</methods>

<methods>
<class-id>Produkt</class-id> <category>instance initialization</category>

<body package="DaskalosUserClasses" selector="initialize">initialize	"	***This is decompiled code.*** 	No source was available"	super initialize.	cena := nil.	popis := nil.	nazevP := nil.	^self</body>
</methods>


</st-source>
