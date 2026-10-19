#### [DiGi\.BDOT10k](DiGi.BDOT10k.Overview.md 'DiGi\.BDOT10k\.Overview')

## DiGi\.BDOT10k\.Classes Namespace
### Classes

<a name='DiGi.BDOT10k.Classes.OT_ADJA_A'></a>

## OT\_ADJA\_A Class

Reprezentuje obiekt jednostki administracyjnej w ramach podziału terytorialnego \(BDOT10k\)\.

```csharp
public class OT_ADJA_A : DiGi.BDOT10k.Classes.OT_PodzialTerytorialny, DiGi.BDOT10k.Interfaces.IOT_PowierzchniowyObiektGeometryczny, DiGi.BDOT10k.Interfaces.IOT_ObiektGeometryczny<DiGi.GML.Classes.Surface>, DiGi.BDOT10k.Interfaces.IOT_ObiektGeometryczny, DiGi.GML.Interfaces.IAbstractGML, DiGi.GML.Interfaces.IFeatureMember
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.GML\.Classes\.AbstractGML](https://learn.microsoft.com/en-us/dotnet/api/digi.gml.classes.abstractgml 'DiGi\.GML\.Classes\.AbstractGML') → [DiGi\.GML\.Classes\.GML](https://learn.microsoft.com/en-us/dotnet/api/digi.gml.classes.gml 'DiGi\.GML\.Classes\.GML') → [OT\_ObiektTopograficzny](DiGi.BDOT10k.Classes.md#DiGi.BDOT10k.Classes.OT_ObiektTopograficzny 'DiGi\.BDOT10k\.Classes\.OT\_ObiektTopograficzny') → [OT\_PodzialTerytorialny](DiGi.BDOT10k.Classes.md#DiGi.BDOT10k.Classes.OT_PodzialTerytorialny 'DiGi\.BDOT10k\.Classes\.OT\_PodzialTerytorialny') → OT\_ADJA\_A

Implements [IOT\_PowierzchniowyObiektGeometryczny](DiGi.BDOT10k.Interfaces.md#DiGi.BDOT10k.Interfaces.IOT_PowierzchniowyObiektGeometryczny 'DiGi\.BDOT10k\.Interfaces\.IOT\_PowierzchniowyObiektGeometryczny'), [DiGi\.BDOT10k\.Interfaces\.IOT\_ObiektGeometryczny&lt;](DiGi.BDOT10k.Interfaces.md#DiGi.BDOT10k.Interfaces.IOT_ObiektGeometryczny_T_ 'DiGi\.BDOT10k\.Interfaces\.IOT\_ObiektGeometryczny\<T\>')[DiGi\.GML\.Classes\.Surface](https://learn.microsoft.com/en-us/dotnet/api/digi.gml.classes.surface 'DiGi\.GML\.Classes\.Surface')[&gt;](DiGi.BDOT10k.Interfaces.md#DiGi.BDOT10k.Interfaces.IOT_ObiektGeometryczny_T_ 'DiGi\.BDOT10k\.Interfaces\.IOT\_ObiektGeometryczny\<T\>'), [IOT\_ObiektGeometryczny](DiGi.BDOT10k.Interfaces.md#DiGi.BDOT10k.Interfaces.IOT_ObiektGeometryczny 'DiGi\.BDOT10k\.Interfaces\.IOT\_ObiektGeometryczny'), [DiGi\.GML\.Interfaces\.IAbstractGML](https://learn.microsoft.com/en-us/dotnet/api/digi.gml.interfaces.iabstractgml 'DiGi\.GML\.Interfaces\.IAbstractGML'), [DiGi\.GML\.Interfaces\.IFeatureMember](https://learn.microsoft.com/en-us/dotnet/api/digi.gml.interfaces.ifeaturemember 'DiGi\.GML\.Interfaces\.IFeatureMember')
### Constructors

<a name='DiGi.BDOT10k.Classes.OT_ADJA_A.OT_ADJA_A()'></a>

## OT\_ADJA\_A\(\) Constructor

Inicjalizuje nową instancję klasy [OT\_ADJA\_A](DiGi.BDOT10k.Classes.md#DiGi.BDOT10k.Classes.OT_ADJA_A 'DiGi\.BDOT10k\.Classes\.OT\_ADJA\_A')\.

```csharp
public OT_ADJA_A();
```
### Properties

<a name='DiGi.BDOT10k.Classes.OT_ADJA_A.geometria'></a>

## OT\_ADJA\_A\.geometria Property

Geometria powierzchniowa obiektu\.

```csharp
public DiGi.GML.Classes.Surface geometria { get; set; }
```

Implements [geometria](DiGi.BDOT10k.Interfaces.md#DiGi.BDOT10k.Interfaces.IOT_ObiektGeometryczny_T_.geometria 'DiGi\.BDOT10k\.Interfaces\.IOT\_ObiektGeometryczny\<T\>\.geometria')

#### Property Value
[DiGi\.GML\.Classes\.Surface](https://learn.microsoft.com/en-us/dotnet/api/digi.gml.classes.surface 'DiGi\.GML\.Classes\.Surface')

<a name='DiGi.BDOT10k.Classes.OT_ADJA_A.identyfikatorPRG'></a>

## OT\_ADJA\_A\.identyfikatorPRG Property

Identyfikator PRG jednostki administracyjnej\.

```csharp
public string identyfikatorPRG { get; set; }
```

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.BDOT10k.Classes.OT_ADJA_A.identyfikatorTERYTjednostki'></a>

## OT\_ADJA\_A\.identyfikatorTERYTjednostki Property

Identyfikator TERYT jednostki administracyjnej\.

```csharp
public string identyfikatorTERYTjednostki { get; set; }
```

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.BDOT10k.Classes.OT_ADJA_A.idTERYTjednostkiNadrzednej'></a>

## OT\_ADJA\_A\.idTERYTjednostkiNadrzednej Property

Identyfikator TERYT jednostki nadrzędnej\.

```csharp
public string? idTERYTjednostkiNadrzednej { get; set; }
```

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.BDOT10k.Classes.OT_ADJA_A.rodzaj'></a>

## OT\_ADJA\_A\.rodzaj Property

Rodzaj jednostki administracyjnej\.

```csharp
public DiGi.BDOT10k.Enums.OT_RodzajJednostkiAdministracyjnej rodzaj { get; set; }
```

#### Property Value
[OT\_RodzajJednostkiAdministracyjnej](DiGi.BDOT10k.Enums.md#DiGi.BDOT10k.Enums.OT_RodzajJednostkiAdministracyjnej 'DiGi\.BDOT10k\.Enums\.OT\_RodzajJednostkiAdministracyjnej')

<a name='DiGi.BDOT10k.Classes.OT_ADMS_A'></a>

## OT\_ADMS\_A Class

Reprezentuje obiekt administracyjny typu A w ramach podziału terytorialnego BDOT10k\.

```csharp
public class OT_ADMS_A : DiGi.BDOT10k.Classes.OT_PodzialTerytorialny, DiGi.BDOT10k.Interfaces.IOT_PowierzchniowyObiektGeometryczny, DiGi.BDOT10k.Interfaces.IOT_ObiektGeometryczny<DiGi.GML.Classes.Surface>, DiGi.BDOT10k.Interfaces.IOT_ObiektGeometryczny, DiGi.GML.Interfaces.IAbstractGML, DiGi.GML.Interfaces.IFeatureMember
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.GML\.Classes\.AbstractGML](https://learn.microsoft.com/en-us/dotnet/api/digi.gml.classes.abstractgml 'DiGi\.GML\.Classes\.AbstractGML') → [DiGi\.GML\.Classes\.GML](https://learn.microsoft.com/en-us/dotnet/api/digi.gml.classes.gml 'DiGi\.GML\.Classes\.GML') → [OT\_ObiektTopograficzny](DiGi.BDOT10k.Classes.md#DiGi.BDOT10k.Classes.OT_ObiektTopograficzny 'DiGi\.BDOT10k\.Classes\.OT\_ObiektTopograficzny') → [OT\_PodzialTerytorialny](DiGi.BDOT10k.Classes.md#DiGi.BDOT10k.Classes.OT_PodzialTerytorialny 'DiGi\.BDOT10k\.Classes\.OT\_PodzialTerytorialny') → OT\_ADMS\_A

Implements [IOT\_PowierzchniowyObiektGeometryczny](DiGi.BDOT10k.Interfaces.md#DiGi.BDOT10k.Interfaces.IOT_PowierzchniowyObiektGeometryczny 'DiGi\.BDOT10k\.Interfaces\.IOT\_PowierzchniowyObiektGeometryczny'), [DiGi\.BDOT10k\.Interfaces\.IOT\_ObiektGeometryczny&lt;](DiGi.BDOT10k.Interfaces.md#DiGi.BDOT10k.Interfaces.IOT_ObiektGeometryczny_T_ 'DiGi\.BDOT10k\.Interfaces\.IOT\_ObiektGeometryczny\<T\>')[DiGi\.GML\.Classes\.Surface](https://learn.microsoft.com/en-us/dotnet/api/digi.gml.classes.surface 'DiGi\.GML\.Classes\.Surface')[&gt;](DiGi.BDOT10k.Interfaces.md#DiGi.BDOT10k.Interfaces.IOT_ObiektGeometryczny_T_ 'DiGi\.BDOT10k\.Interfaces\.IOT\_ObiektGeometryczny\<T\>'), [IOT\_ObiektGeometryczny](DiGi.BDOT10k.Interfaces.md#DiGi.BDOT10k.Interfaces.IOT_ObiektGeometryczny 'DiGi\.BDOT10k\.Interfaces\.IOT\_ObiektGeometryczny'), [DiGi\.GML\.Interfaces\.IAbstractGML](https://learn.microsoft.com/en-us/dotnet/api/digi.gml.interfaces.iabstractgml 'DiGi\.GML\.Interfaces\.IAbstractGML'), [DiGi\.GML\.Interfaces\.IFeatureMember](https://learn.microsoft.com/en-us/dotnet/api/digi.gml.interfaces.ifeaturemember 'DiGi\.GML\.Interfaces\.IFeatureMember')
### Constructors

<a name='DiGi.BDOT10k.Classes.OT_ADMS_A.OT_ADMS_A()'></a>

## OT\_ADMS\_A\(\) Constructor

Inicjalizuje nową instancję klasy [OT\_ADMS\_A](DiGi.BDOT10k.Classes.md#DiGi.BDOT10k.Classes.OT_ADMS_A 'DiGi\.BDOT10k\.Classes\.OT\_ADMS\_A')\.

```csharp
public OT_ADMS_A();
```
### Properties

<a name='DiGi.BDOT10k.Classes.OT_ADMS_A.geometria'></a>

## OT\_ADMS\_A\.geometria Property

Geometria powierzchniowa obiektu\.

```csharp
public DiGi.GML.Classes.Surface geometria { get; set; }
```

Implements [geometria](DiGi.BDOT10k.Interfaces.md#DiGi.BDOT10k.Interfaces.IOT_ObiektGeometryczny_T_.geometria 'DiGi\.BDOT10k\.Interfaces\.IOT\_ObiektGeometryczny\<T\>\.geometria')

#### Property Value
[DiGi\.GML\.Classes\.Surface](https://learn.microsoft.com/en-us/dotnet/api/digi.gml.classes.surface 'DiGi\.GML\.Classes\.Surface')

<a name='DiGi.BDOT10k.Classes.OT_ADMS_A.identyfikatorPRNG'></a>

## OT\_ADMS\_A\.identyfikatorPRNG Property

Identyfikator PRNG\.

```csharp
public string identyfikatorPRNG { get; set; }
```

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.BDOT10k.Classes.OT_ADMS_A.identyfikatorSIMC'></a>

## OT\_ADMS\_A\.identyfikatorSIMC Property

Identyfikator SIMC \(System Identyfikacji Miejscowości i Członów\)\.

```csharp
public string? identyfikatorSIMC { get; set; }
```

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.BDOT10k.Classes.OT_ADMS_A.identyfikatorTERC'></a>

## OT\_ADMS\_A\.identyfikatorTERC Property

Identyfikator TERC\.

```csharp
public string identyfikatorTERC { get; set; }
```

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.BDOT10k.Classes.OT_ADMS_A.liczbaMieszkancow'></a>

## OT\_ADMS\_A\.liczbaMieszkancow Property

Liczba mieszkańców\.

```csharp
public System.Nullable<uint> liczbaMieszkancow { get; set; }
```

#### Property Value
[System\.Nullable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')[System\.UInt32](https://learn.microsoft.com/en-us/dotnet/api/system.uint32 'System\.UInt32')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')

<a name='DiGi.BDOT10k.Classes.OT_ADMS_A.rodzaj'></a>

## OT\_ADMS\_A\.rodzaj Property

Rodzaj miejscowości\.

```csharp
public DiGi.BDOT10k.Enums.OT_RodzajMiejscowosci rodzaj { get; set; }
```

#### Property Value
[OT\_RodzajMiejscowosci](DiGi.BDOT10k.Enums.md#DiGi.BDOT10k.Enums.OT_RodzajMiejscowosci 'DiGi\.BDOT10k\.Enums\.OT\_RodzajMiejscowosci')

<a name='DiGi.BDOT10k.Classes.OT_BUBD_A'></a>

## OT\_BUBD\_A Class

Reprezentuje obiekt budynku w standardzie BDOT10k\.

```csharp
public class OT_BUBD_A : DiGi.BDOT10k.Classes.OT_BudynkiBudowleIUrzadzenia, DiGi.BDOT10k.Interfaces.IOT_PowierzchniowyObiektGeometryczny, DiGi.BDOT10k.Interfaces.IOT_ObiektGeometryczny<DiGi.GML.Classes.Surface>, DiGi.BDOT10k.Interfaces.IOT_ObiektGeometryczny, DiGi.GML.Interfaces.IAbstractGML, DiGi.GML.Interfaces.IFeatureMember
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.GML\.Classes\.AbstractGML](https://learn.microsoft.com/en-us/dotnet/api/digi.gml.classes.abstractgml 'DiGi\.GML\.Classes\.AbstractGML') → [DiGi\.GML\.Classes\.GML](https://learn.microsoft.com/en-us/dotnet/api/digi.gml.classes.gml 'DiGi\.GML\.Classes\.GML') → [OT\_ObiektTopograficzny](DiGi.BDOT10k.Classes.md#DiGi.BDOT10k.Classes.OT_ObiektTopograficzny 'DiGi\.BDOT10k\.Classes\.OT\_ObiektTopograficzny') → [OT\_BudynkiBudowleIUrzadzenia](DiGi.BDOT10k.Classes.md#DiGi.BDOT10k.Classes.OT_BudynkiBudowleIUrzadzenia 'DiGi\.BDOT10k\.Classes\.OT\_BudynkiBudowleIUrzadzenia') → OT\_BUBD\_A

Implements [IOT\_PowierzchniowyObiektGeometryczny](DiGi.BDOT10k.Interfaces.md#DiGi.BDOT10k.Interfaces.IOT_PowierzchniowyObiektGeometryczny 'DiGi\.BDOT10k\.Interfaces\.IOT\_PowierzchniowyObiektGeometryczny'), [DiGi\.BDOT10k\.Interfaces\.IOT\_ObiektGeometryczny&lt;](DiGi.BDOT10k.Interfaces.md#DiGi.BDOT10k.Interfaces.IOT_ObiektGeometryczny_T_ 'DiGi\.BDOT10k\.Interfaces\.IOT\_ObiektGeometryczny\<T\>')[DiGi\.GML\.Classes\.Surface](https://learn.microsoft.com/en-us/dotnet/api/digi.gml.classes.surface 'DiGi\.GML\.Classes\.Surface')[&gt;](DiGi.BDOT10k.Interfaces.md#DiGi.BDOT10k.Interfaces.IOT_ObiektGeometryczny_T_ 'DiGi\.BDOT10k\.Interfaces\.IOT\_ObiektGeometryczny\<T\>'), [IOT\_ObiektGeometryczny](DiGi.BDOT10k.Interfaces.md#DiGi.BDOT10k.Interfaces.IOT_ObiektGeometryczny 'DiGi\.BDOT10k\.Interfaces\.IOT\_ObiektGeometryczny'), [DiGi\.GML\.Interfaces\.IAbstractGML](https://learn.microsoft.com/en-us/dotnet/api/digi.gml.interfaces.iabstractgml 'DiGi\.GML\.Interfaces\.IAbstractGML'), [DiGi\.GML\.Interfaces\.IFeatureMember](https://learn.microsoft.com/en-us/dotnet/api/digi.gml.interfaces.ifeaturemember 'DiGi\.GML\.Interfaces\.IFeatureMember')
### Constructors

<a name='DiGi.BDOT10k.Classes.OT_BUBD_A.OT_BUBD_A()'></a>

## OT\_BUBD\_A\(\) Constructor

Inicjalizuje nową instancję klasy [OT\_BUBD\_A](DiGi.BDOT10k.Classes.md#DiGi.BDOT10k.Classes.OT_BUBD_A 'DiGi\.BDOT10k\.Classes\.OT\_BUBD\_A')\.

```csharp
public OT_BUBD_A();
```
### Properties

<a name='DiGi.BDOT10k.Classes.OT_BUBD_A.funkcjaOgolnaBudynku'></a>

## OT\_BUBD\_A\.funkcjaOgolnaBudynku Property

Ogólna funkcja budynku\.

```csharp
public System.Nullable<DiGi.BDOT10k.Enums.OT_FunOgolnaBudynku> funkcjaOgolnaBudynku { get; set; }
```

#### Property Value
[System\.Nullable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')[OT\_FunOgolnaBudynku](DiGi.BDOT10k.Enums.md#DiGi.BDOT10k.Enums.OT_FunOgolnaBudynku 'DiGi\.BDOT10k\.Enums\.OT\_FunOgolnaBudynku')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')

<a name='DiGi.BDOT10k.Classes.OT_BUBD_A.funkcjaSzczegolowaBudynku'></a>

## OT\_BUBD\_A\.funkcjaSzczegolowaBudynku Property

Lista szczegółowych funkcji budynku\.

```csharp
public System.Collections.Generic.List<DiGi.BDOT10k.Enums.OT_FunSzczegolowaBudynku>? funkcjaSzczegolowaBudynku { get; set; }
```

#### Property Value
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[OT\_FunSzczegolowaBudynku](DiGi.BDOT10k.Enums.md#DiGi.BDOT10k.Enums.OT_FunSzczegolowaBudynku 'DiGi\.BDOT10k\.Enums\.OT\_FunSzczegolowaBudynku')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')

<a name='DiGi.BDOT10k.Classes.OT_BUBD_A.geometria'></a>

## OT\_BUBD\_A\.geometria Property

Geometria powierzchniowa obiektu\.

```csharp
public DiGi.GML.Classes.Surface geometria { get; set; }
```

Implements [geometria](DiGi.BDOT10k.Interfaces.md#DiGi.BDOT10k.Interfaces.IOT_ObiektGeometryczny_T_.geometria 'DiGi\.BDOT10k\.Interfaces\.IOT\_ObiektGeometryczny\<T\>\.geometria')

#### Property Value
[DiGi\.GML\.Classes\.Surface](https://learn.microsoft.com/en-us/dotnet/api/digi.gml.classes.surface 'DiGi\.GML\.Classes\.Surface')

<a name='DiGi.BDOT10k.Classes.OT_BUBD_A.identyfikatorEGiB'></a>

## OT\_BUBD\_A\.identyfikatorEGiB Property

Lista identyfikatorów z Ewidencji Gruntów i Budynków \(EGiB\)\.

```csharp
public System.Collections.Generic.List<string>? identyfikatorEGiB { get; set; }
```

#### Property Value
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')

<a name='DiGi.BDOT10k.Classes.OT_BUBD_A.kodKst'></a>

## OT\_BUBD\_A\.kodKst Property

Kod klasyfikacji obiektów budowlanych \(KST\)\.

```csharp
public string? kodKst { get; set; }
```

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.BDOT10k.Classes.OT_BUBD_A.liczbaKondygnacji'></a>

## OT\_BUBD\_A\.liczbaKondygnacji Property

Liczba kondygnacji w budynku\.

```csharp
public System.Nullable<ushort> liczbaKondygnacji { get; set; }
```

#### Property Value
[System\.Nullable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')[System\.UInt16](https://learn.microsoft.com/en-us/dotnet/api/system.uint16 'System\.UInt16')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')

<a name='DiGi.BDOT10k.Classes.OT_BUBD_A.nazwa'></a>

## OT\_BUBD\_A\.nazwa Property

Nazwa budynku\.

```csharp
public string? nazwa { get; set; }
```

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.BDOT10k.Classes.OT_BUBD_A.przewazajacaFunkcjaBudynku'></a>

## OT\_BUBD\_A\.przewazajacaFunkcjaBudynku Property

Przeważająca funkcja budynku\.

```csharp
public DiGi.BDOT10k.Enums.OT_FunSzczegolowaBudynku przewazajacaFunkcjaBudynku { get; set; }
```

#### Property Value
[OT\_FunSzczegolowaBudynku](DiGi.BDOT10k.Enums.md#DiGi.BDOT10k.Enums.OT_FunSzczegolowaBudynku 'DiGi\.BDOT10k\.Enums\.OT\_FunSzczegolowaBudynku')

<a name='DiGi.BDOT10k.Classes.OT_BudynkiBudowleIUrzadzenia'></a>

## OT\_BudynkiBudowleIUrzadzenia Class

Klasa bazowa dla obiektów topograficznych będących budynkami, budowlami i urządzeniami w standardzie BDOT10k\.

```csharp
public abstract class OT_BudynkiBudowleIUrzadzenia : DiGi.BDOT10k.Classes.OT_ObiektTopograficzny
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.GML\.Classes\.AbstractGML](https://learn.microsoft.com/en-us/dotnet/api/digi.gml.classes.abstractgml 'DiGi\.GML\.Classes\.AbstractGML') → [DiGi\.GML\.Classes\.GML](https://learn.microsoft.com/en-us/dotnet/api/digi.gml.classes.gml 'DiGi\.GML\.Classes\.GML') → [OT\_ObiektTopograficzny](DiGi.BDOT10k.Classes.md#DiGi.BDOT10k.Classes.OT_ObiektTopograficzny 'DiGi\.BDOT10k\.Classes\.OT\_ObiektTopograficzny') → OT\_BudynkiBudowleIUrzadzenia

Derived  
↳ [OT\_BUBD\_A](DiGi.BDOT10k.Classes.md#DiGi.BDOT10k.Classes.OT_BUBD_A 'DiGi\.BDOT10k\.Classes\.OT\_BUBD\_A')
### Constructors

<a name='DiGi.BDOT10k.Classes.OT_BudynkiBudowleIUrzadzenia.OT_BudynkiBudowleIUrzadzenia()'></a>

## OT\_BudynkiBudowleIUrzadzenia\(\) Constructor

Inicjalizuje nową instancję klasy [OT\_BudynkiBudowleIUrzadzenia](DiGi.BDOT10k.Classes.md#DiGi.BDOT10k.Classes.OT_BudynkiBudowleIUrzadzenia 'DiGi\.BDOT10k\.Classes\.OT\_BudynkiBudowleIUrzadzenia')\.

```csharp
public OT_BudynkiBudowleIUrzadzenia();
```

<a name='DiGi.BDOT10k.Classes.OT_CharakterystykaDrogi'></a>

## OT\_CharakterystykaDrogi Class

Abstract base of the BDOT10k road classes [OT\_SKJZ\_L](DiGi.BDOT10k.Classes.md#DiGi.BDOT10k.Classes.OT_SKJZ_L 'DiGi\.BDOT10k\.Classes\.OT\_SKJZ\_L') \(carriageway\) and [OT\_SKDR\_L](DiGi.BDOT10k.Classes.md#DiGi.BDOT10k.Classes.OT_SKDR_L 'DiGi\.BDOT10k\.Classes\.OT\_SKDR\_L') \(road\), holding the attributes they share\.

Mirrors the abstract UML class `OT_CharakterystykaDrogi` of Annex 2 to Dz.U. 2021 poz. 1412, which derives directly from `OT_ObiektTopograficzny`. Property names are the GML element names, because the GML parser binds elements to properties by name.

```csharp
public abstract class OT_CharakterystykaDrogi : DiGi.BDOT10k.Classes.OT_ObiektTopograficzny, DiGi.BDOT10k.Interfaces.IOT_LiniowyObiektGeometryczny, DiGi.BDOT10k.Interfaces.IOT_ObiektGeometryczny<DiGi.GML.Classes.AbstractCurve>, DiGi.BDOT10k.Interfaces.IOT_ObiektGeometryczny, DiGi.GML.Interfaces.IAbstractGML, DiGi.GML.Interfaces.IFeatureMember
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.GML\.Classes\.AbstractGML](https://learn.microsoft.com/en-us/dotnet/api/digi.gml.classes.abstractgml 'DiGi\.GML\.Classes\.AbstractGML') → [DiGi\.GML\.Classes\.GML](https://learn.microsoft.com/en-us/dotnet/api/digi.gml.classes.gml 'DiGi\.GML\.Classes\.GML') → [OT\_ObiektTopograficzny](DiGi.BDOT10k.Classes.md#DiGi.BDOT10k.Classes.OT_ObiektTopograficzny 'DiGi\.BDOT10k\.Classes\.OT\_ObiektTopograficzny') → OT\_CharakterystykaDrogi

Derived  
↳ [OT\_SKDR\_L](DiGi.BDOT10k.Classes.md#DiGi.BDOT10k.Classes.OT_SKDR_L 'DiGi\.BDOT10k\.Classes\.OT\_SKDR\_L')  
↳ [OT\_SKJZ\_L](DiGi.BDOT10k.Classes.md#DiGi.BDOT10k.Classes.OT_SKJZ_L 'DiGi\.BDOT10k\.Classes\.OT\_SKJZ\_L')

Implements [IOT\_LiniowyObiektGeometryczny](DiGi.BDOT10k.Interfaces.md#DiGi.BDOT10k.Interfaces.IOT_LiniowyObiektGeometryczny 'DiGi\.BDOT10k\.Interfaces\.IOT\_LiniowyObiektGeometryczny'), [DiGi\.BDOT10k\.Interfaces\.IOT\_ObiektGeometryczny&lt;](DiGi.BDOT10k.Interfaces.md#DiGi.BDOT10k.Interfaces.IOT_ObiektGeometryczny_T_ 'DiGi\.BDOT10k\.Interfaces\.IOT\_ObiektGeometryczny\<T\>')[DiGi\.GML\.Classes\.AbstractCurve](https://learn.microsoft.com/en-us/dotnet/api/digi.gml.classes.abstractcurve 'DiGi\.GML\.Classes\.AbstractCurve')[&gt;](DiGi.BDOT10k.Interfaces.md#DiGi.BDOT10k.Interfaces.IOT_ObiektGeometryczny_T_ 'DiGi\.BDOT10k\.Interfaces\.IOT\_ObiektGeometryczny\<T\>'), [IOT\_ObiektGeometryczny](DiGi.BDOT10k.Interfaces.md#DiGi.BDOT10k.Interfaces.IOT_ObiektGeometryczny 'DiGi\.BDOT10k\.Interfaces\.IOT\_ObiektGeometryczny'), [DiGi\.GML\.Interfaces\.IAbstractGML](https://learn.microsoft.com/en-us/dotnet/api/digi.gml.interfaces.iabstractgml 'DiGi\.GML\.Interfaces\.IAbstractGML'), [DiGi\.GML\.Interfaces\.IFeatureMember](https://learn.microsoft.com/en-us/dotnet/api/digi.gml.interfaces.ifeaturemember 'DiGi\.GML\.Interfaces\.IFeatureMember')
### Constructors

<a name='DiGi.BDOT10k.Classes.OT_CharakterystykaDrogi.OT_CharakterystykaDrogi()'></a>

## OT\_CharakterystykaDrogi\(\) Constructor

Initializes a new instance of the [OT\_CharakterystykaDrogi](DiGi.BDOT10k.Classes.md#DiGi.BDOT10k.Classes.OT_CharakterystykaDrogi 'DiGi\.BDOT10k\.Classes\.OT\_CharakterystykaDrogi') class\.

```csharp
public OT_CharakterystykaDrogi();
```
### Properties

<a name='DiGi.BDOT10k.Classes.OT_CharakterystykaDrogi.geometria'></a>

## OT\_CharakterystykaDrogi\.geometria Property

Gets or sets the linear geometry of the object\.

```csharp
public DiGi.GML.Classes.AbstractCurve geometria { get; set; }
```

Implements [geometria](DiGi.BDOT10k.Interfaces.md#DiGi.BDOT10k.Interfaces.IOT_ObiektGeometryczny_T_.geometria 'DiGi\.BDOT10k\.Interfaces\.IOT\_ObiektGeometryczny\<T\>\.geometria')

#### Property Value
[DiGi\.GML\.Classes\.AbstractCurve](https://learn.microsoft.com/en-us/dotnet/api/digi.gml.classes.abstractcurve 'DiGi\.GML\.Classes\.AbstractCurve')

<a name='DiGi.BDOT10k.Classes.OT_CharakterystykaDrogi.kategoriaZarzadzania'></a>

## OT\_CharakterystykaDrogi\.kategoriaZarzadzania Property

Gets or sets the management category of the road\.

```csharp
public System.Nullable<DiGi.BDOT10k.Enums.OT_KatZarzadzaniaDrogi> kategoriaZarzadzania { get; set; }
```

#### Property Value
[System\.Nullable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')[OT\_KatZarzadzaniaDrogi](DiGi.BDOT10k.Enums.md#DiGi.BDOT10k.Enums.OT_KatZarzadzaniaDrogi 'DiGi\.BDOT10k\.Enums\.OT\_KatZarzadzaniaDrogi')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')

<a name='DiGi.BDOT10k.Classes.OT_CharakterystykaDrogi.klasaDrogi'></a>

## OT\_CharakterystykaDrogi\.klasaDrogi Property

Gets or sets the technical class of the road\.

```csharp
public System.Nullable<DiGi.BDOT10k.Enums.OT_KlasaDrogi> klasaDrogi { get; set; }
```

#### Property Value
[System\.Nullable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')[OT\_KlasaDrogi](DiGi.BDOT10k.Enums.md#DiGi.BDOT10k.Enums.OT_KlasaDrogi 'DiGi\.BDOT10k\.Enums\.OT\_KlasaDrogi')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')

<a name='DiGi.BDOT10k.Classes.OT_CharakterystykaDrogi.liczbaJezdniDrogi'></a>

## OT\_CharakterystykaDrogi\.liczbaJezdniDrogi Property

Gets or sets the number of carriageways of the road\.

```csharp
public System.Nullable<int> liczbaJezdniDrogi { get; set; }
```

#### Property Value
[System\.Nullable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')

<a name='DiGi.BDOT10k.Classes.OT_CharakterystykaDrogi.materialNawierzchni'></a>

## OT\_CharakterystykaDrogi\.materialNawierzchni Property

Gets or sets the surface material\.

```csharp
public System.Nullable<DiGi.BDOT10k.Enums.OT_MaterialNawierzchni> materialNawierzchni { get; set; }
```

#### Property Value
[System\.Nullable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')[OT\_MaterialNawierzchni](DiGi.BDOT10k.Enums.md#DiGi.BDOT10k.Enums.OT_MaterialNawierzchni 'DiGi\.BDOT10k\.Enums\.OT\_MaterialNawierzchni')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')

<a name='DiGi.BDOT10k.Classes.OT_CharakterystykaDrogi.nazwaDrogi'></a>

## OT\_CharakterystykaDrogi\.nazwaDrogi Property

Gets or sets the proper name of the road, which is not a street name\.

```csharp
public string? nazwaDrogi { get; set; }
```

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.BDOT10k.Classes.OT_CharakterystykaDrogi.numerDrogi'></a>

## OT\_CharakterystykaDrogi\.numerDrogi Property

Gets or sets the road numbers\. A road segment can carry several, e\.g\. a European and a national number\.

```csharp
public System.Collections.Generic.List<string>? numerDrogi { get; set; }
```

#### Property Value
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')

<a name='DiGi.BDOT10k.Classes.OT_CharakterystykaDrogi.polozenie'></a>

## OT\_CharakterystykaDrogi\.polozenie Property

Gets or sets the position of the road relative to the ground surface\.

```csharp
public System.Nullable<DiGi.BDOT10k.Enums.OT_PolozenieObiektuSieciTransportowej> polozenie { get; set; }
```

#### Property Value
[System\.Nullable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')[OT\_PolozenieObiektuSieciTransportowej](DiGi.BDOT10k.Enums.md#DiGi.BDOT10k.Enums.OT_PolozenieObiektuSieciTransportowej 'DiGi\.BDOT10k\.Enums\.OT\_PolozenieObiektuSieciTransportowej')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')

<a name='DiGi.BDOT10k.Classes.OT_CharakterystykaDrogi.szerokoscNawierzchni'></a>

## OT\_CharakterystykaDrogi\.szerokoscNawierzchni Property

Gets or sets the surface width in metres\.

```csharp
public System.Nullable<double> szerokoscNawierzchni { get; set; }
```

#### Property Value
[System\.Nullable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')

<a name='DiGi.BDOT10k.Classes.OT_ObiektTopograficzny'></a>

## OT\_ObiektTopograficzny Class

Reprezentuje bazową klasę dla obiektów topograficznych w standardzie BDOT10k\.

```csharp
public abstract class OT_ObiektTopograficzny : DiGi.GML.Classes.GML
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.GML\.Classes\.AbstractGML](https://learn.microsoft.com/en-us/dotnet/api/digi.gml.classes.abstractgml 'DiGi\.GML\.Classes\.AbstractGML') → [DiGi\.GML\.Classes\.GML](https://learn.microsoft.com/en-us/dotnet/api/digi.gml.classes.gml 'DiGi\.GML\.Classes\.GML') → OT\_ObiektTopograficzny

Derived  
↳ [OT\_BudynkiBudowleIUrzadzenia](DiGi.BDOT10k.Classes.md#DiGi.BDOT10k.Classes.OT_BudynkiBudowleIUrzadzenia 'DiGi\.BDOT10k\.Classes\.OT\_BudynkiBudowleIUrzadzenia')  
↳ [OT\_CharakterystykaDrogi](DiGi.BDOT10k.Classes.md#DiGi.BDOT10k.Classes.OT_CharakterystykaDrogi 'DiGi\.BDOT10k\.Classes\.OT\_CharakterystykaDrogi')  
↳ [OT\_PodzialTerytorialny](DiGi.BDOT10k.Classes.md#DiGi.BDOT10k.Classes.OT_PodzialTerytorialny 'DiGi\.BDOT10k\.Classes\.OT\_PodzialTerytorialny')  
↳ [OT\_SKRP\_L](DiGi.BDOT10k.Classes.md#DiGi.BDOT10k.Classes.OT_SKRP_L 'DiGi\.BDOT10k\.Classes\.OT\_SKRP\_L')
### Constructors

<a name='DiGi.BDOT10k.Classes.OT_ObiektTopograficzny.OT_ObiektTopograficzny()'></a>

## OT\_ObiektTopograficzny\(\) Constructor

Inicjalizuje nową instancję klasy [OT\_ObiektTopograficzny](DiGi.BDOT10k.Classes.md#DiGi.BDOT10k.Classes.OT_ObiektTopograficzny 'DiGi\.BDOT10k\.Classes\.OT\_ObiektTopograficzny')\.

```csharp
public OT_ObiektTopograficzny();
```
### Properties

<a name='DiGi.BDOT10k.Classes.OT_ObiektTopograficzny.informacjaDodatkowa'></a>

## OT\_ObiektTopograficzny\.informacjaDodatkowa Property

Pobiera lub ustawia dodatkowe informacje o obiekcie\.

```csharp
public string? informacjaDodatkowa { get; set; }
```

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.BDOT10k.Classes.OT_ObiektTopograficzny.kategoriaIstnienia'></a>

## OT\_ObiektTopograficzny\.kategoriaIstnienia Property

Pobiera lub ustawia kategorię istnienia obiektu topograficznego\.

```csharp
public DiGi.BDOT10k.Enums.OT_KatIstnienia kategoriaIstnienia { get; set; }
```

#### Property Value
[OT\_KatIstnienia](DiGi.BDOT10k.Enums.md#DiGi.BDOT10k.Enums.OT_KatIstnienia 'DiGi\.BDOT10k\.Enums\.OT\_KatIstnienia')

<a name='DiGi.BDOT10k.Classes.OT_ObiektTopograficzny.kodKarto10k'></a>

## OT\_ObiektTopograficzny\.kodKarto10k Property

Pobiera lub ustawia kod kartograficzny dla mapy w skali 1:10 000\.

```csharp
public string? kodKarto10k { get; set; }
```

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.BDOT10k.Classes.OT_ObiektTopograficzny.kodKarto250k'></a>

## OT\_ObiektTopograficzny\.kodKarto250k Property

Pobiera lub ustawia kod kartograficzny dla mapy w skali 1:250 000\.

```csharp
public string? kodKarto250k { get; set; }
```

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.BDOT10k.Classes.OT_ObiektTopograficzny.koniecWersjiObiektu'></a>

## OT\_ObiektTopograficzny\.koniecWersjiObiektu Property

Pobiera lub ustawia datę zakończenia obowiązywania wersji obiektu\.

```csharp
public System.Nullable<System.DateTime> koniecWersjiObiektu { get; set; }
```

#### Property Value
[System\.Nullable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')[System\.DateTime](https://learn.microsoft.com/en-us/dotnet/api/system.datetime 'System\.DateTime')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')

<a name='DiGi.BDOT10k.Classes.OT_ObiektTopograficzny.lokalnyId'></a>

## OT\_ObiektTopograficzny\.lokalnyId Property

Pobiera lub ustawia lokalny identyfikator obiektu\.

```csharp
public string lokalnyId { get; set; }
```

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.BDOT10k.Classes.OT_ObiektTopograficzny.oznaczenieZmiany'></a>

## OT\_ObiektTopograficzny\.oznaczenieZmiany Property

Pobiera lub ustawia oznaczenie wprowadzonej zmiany w obiekcie\.

```csharp
public string oznaczenieZmiany { get; set; }
```

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.BDOT10k.Classes.OT_ObiektTopograficzny.poczatekWersjiObiektu'></a>

## OT\_ObiektTopograficzny\.poczatekWersjiObiektu Property

Pobiera lub ustawia datę rozpoczęcia obowiązywania wersji obiektu\.

```csharp
public System.DateTime poczatekWersjiObiektu { get; set; }
```

#### Property Value
[System\.DateTime](https://learn.microsoft.com/en-us/dotnet/api/system.datetime 'System\.DateTime')

<a name='DiGi.BDOT10k.Classes.OT_ObiektTopograficzny.przestrzenNazw'></a>

## OT\_ObiektTopograficzny\.przestrzenNazw Property

Pobiera lub ustawia przestrzeń nazw, do której należy obiekt\.

```csharp
public string przestrzenNazw { get; set; }
```

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.BDOT10k.Classes.OT_ObiektTopograficzny.skrotKartograficzny'></a>

## OT\_ObiektTopograficzny\.skrotKartograficzny Property

Pobiera lub ustawia skrót kartograficzny obiektu\.

```csharp
public string? skrotKartograficzny { get; set; }
```

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.BDOT10k.Classes.OT_ObiektTopograficzny.uwagi'></a>

## OT\_ObiektTopograficzny\.uwagi Property

Pobiera lub ustawia uwagi dotyczące obiektu\.

```csharp
public string? uwagi { get; set; }
```

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.BDOT10k.Classes.OT_ObiektTopograficzny.wersja'></a>

## OT\_ObiektTopograficzny\.wersja Property

Pobiera lub ustawia datę i godzinę wersji obiektu\.

```csharp
public System.DateTime wersja { get; set; }
```

#### Property Value
[System\.DateTime](https://learn.microsoft.com/en-us/dotnet/api/system.datetime 'System\.DateTime')

<a name='DiGi.BDOT10k.Classes.OT_ObiektTopograficzny.zrodloDanychGeometrycznych'></a>

## OT\_ObiektTopograficzny\.zrodloDanychGeometrycznych Property

Pobiera lub ustawia źródło danych geometrycznych obiektu\.

```csharp
public DiGi.BDOT10k.Enums.OT_ZrodloDanych zrodloDanychGeometrycznych { get; set; }
```

#### Property Value
[OT\_ZrodloDanych](DiGi.BDOT10k.Enums.md#DiGi.BDOT10k.Enums.OT_ZrodloDanych 'DiGi\.BDOT10k\.Enums\.OT\_ZrodloDanych')

<a name='DiGi.BDOT10k.Classes.OT_PodzialTerytorialny'></a>

## OT\_PodzialTerytorialny Class

Reprezentuje abstrakcyjną klasę dla obiektów topograficznych należących do podziału terytorialnego\.

```csharp
public abstract class OT_PodzialTerytorialny : DiGi.BDOT10k.Classes.OT_ObiektTopograficzny
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.GML\.Classes\.AbstractGML](https://learn.microsoft.com/en-us/dotnet/api/digi.gml.classes.abstractgml 'DiGi\.GML\.Classes\.AbstractGML') → [DiGi\.GML\.Classes\.GML](https://learn.microsoft.com/en-us/dotnet/api/digi.gml.classes.gml 'DiGi\.GML\.Classes\.GML') → [OT\_ObiektTopograficzny](DiGi.BDOT10k.Classes.md#DiGi.BDOT10k.Classes.OT_ObiektTopograficzny 'DiGi\.BDOT10k\.Classes\.OT\_ObiektTopograficzny') → OT\_PodzialTerytorialny

Derived  
↳ [OT\_ADJA\_A](DiGi.BDOT10k.Classes.md#DiGi.BDOT10k.Classes.OT_ADJA_A 'DiGi\.BDOT10k\.Classes\.OT\_ADJA\_A')  
↳ [OT\_ADMS\_A](DiGi.BDOT10k.Classes.md#DiGi.BDOT10k.Classes.OT_ADMS_A 'DiGi\.BDOT10k\.Classes\.OT\_ADMS\_A')
### Constructors

<a name='DiGi.BDOT10k.Classes.OT_PodzialTerytorialny.OT_PodzialTerytorialny()'></a>

## OT\_PodzialTerytorialny\(\) Constructor

Inicjalizuje nową instancję klasy [OT\_PodzialTerytorialny](DiGi.BDOT10k.Classes.md#DiGi.BDOT10k.Classes.OT_PodzialTerytorialny 'DiGi\.BDOT10k\.Classes\.OT\_PodzialTerytorialny')\.

```csharp
public OT_PodzialTerytorialny();
```
### Properties

<a name='DiGi.BDOT10k.Classes.OT_PodzialTerytorialny.nazwa'></a>

## OT\_PodzialTerytorialny\.nazwa Property

Pobiera lub ustawia nazwę jednostki podziału terytorialnego\.

```csharp
public string nazwa { get; set; }
```

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.BDOT10k.Classes.OT_SKDR_L'></a>

## OT\_SKDR\_L Class

Road \(`droga`\) of the BDOT10k standard: the axis of a single\- or dual\-carriageway road segment\.

It declares no attributes of its own. Its attributes are those of [OT\_CharakterystykaDrogi](DiGi.BDOT10k.Classes.md#DiGi.BDOT10k.Classes.OT_CharakterystykaDrogi 'DiGi\.BDOT10k\.Classes\.OT\_CharakterystykaDrogi') (Annex 3, §2 to Dz.U. 2021 poz. 1412).

```csharp
public class OT_SKDR_L : DiGi.BDOT10k.Classes.OT_CharakterystykaDrogi
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.GML\.Classes\.AbstractGML](https://learn.microsoft.com/en-us/dotnet/api/digi.gml.classes.abstractgml 'DiGi\.GML\.Classes\.AbstractGML') → [DiGi\.GML\.Classes\.GML](https://learn.microsoft.com/en-us/dotnet/api/digi.gml.classes.gml 'DiGi\.GML\.Classes\.GML') → [OT\_ObiektTopograficzny](DiGi.BDOT10k.Classes.md#DiGi.BDOT10k.Classes.OT_ObiektTopograficzny 'DiGi\.BDOT10k\.Classes\.OT\_ObiektTopograficzny') → [OT\_CharakterystykaDrogi](DiGi.BDOT10k.Classes.md#DiGi.BDOT10k.Classes.OT_CharakterystykaDrogi 'DiGi\.BDOT10k\.Classes\.OT\_CharakterystykaDrogi') → OT\_SKDR\_L
### Constructors

<a name='DiGi.BDOT10k.Classes.OT_SKDR_L.OT_SKDR_L()'></a>

## OT\_SKDR\_L\(\) Constructor

Initializes a new instance of the [OT\_SKDR\_L](DiGi.BDOT10k.Classes.md#DiGi.BDOT10k.Classes.OT_SKDR_L 'DiGi\.BDOT10k\.Classes\.OT\_SKDR\_L') class\.

```csharp
public OT_SKDR_L();
```

<a name='DiGi.BDOT10k.Classes.OT_SKJZ_L'></a>

## OT\_SKJZ\_L Class

Carriageway \(`jezdnia`\) of the BDOT10k standard: the axis of a single carriageway segment\.

Besides the road attributes of [OT\_CharakterystykaDrogi](DiGi.BDOT10k.Classes.md#DiGi.BDOT10k.Classes.OT_CharakterystykaDrogi 'DiGi\.BDOT10k\.Classes\.OT\_CharakterystykaDrogi'), a carriageway carries the identity of the street it belongs to, from the TERYT register.

```csharp
public class OT_SKJZ_L : DiGi.BDOT10k.Classes.OT_CharakterystykaDrogi
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.GML\.Classes\.AbstractGML](https://learn.microsoft.com/en-us/dotnet/api/digi.gml.classes.abstractgml 'DiGi\.GML\.Classes\.AbstractGML') → [DiGi\.GML\.Classes\.GML](https://learn.microsoft.com/en-us/dotnet/api/digi.gml.classes.gml 'DiGi\.GML\.Classes\.GML') → [OT\_ObiektTopograficzny](DiGi.BDOT10k.Classes.md#DiGi.BDOT10k.Classes.OT_ObiektTopograficzny 'DiGi\.BDOT10k\.Classes\.OT\_ObiektTopograficzny') → [OT\_CharakterystykaDrogi](DiGi.BDOT10k.Classes.md#DiGi.BDOT10k.Classes.OT_CharakterystykaDrogi 'DiGi\.BDOT10k\.Classes\.OT\_CharakterystykaDrogi') → OT\_SKJZ\_L
### Constructors

<a name='DiGi.BDOT10k.Classes.OT_SKJZ_L.OT_SKJZ_L()'></a>

## OT\_SKJZ\_L\(\) Constructor

Initializes a new instance of the [OT\_SKJZ\_L](DiGi.BDOT10k.Classes.md#DiGi.BDOT10k.Classes.OT_SKJZ_L 'DiGi\.BDOT10k\.Classes\.OT\_SKJZ\_L') class\.

```csharp
public OT_SKJZ_L();
```
### Properties

<a name='DiGi.BDOT10k.Classes.OT_SKJZ_L.cechaGeometrii'></a>

## OT\_SKJZ\_L\.cechaGeometrii Property

Gets or sets the kind of geometric representation\.

Nullable although the UML gives it multiplicity 1: in the Geoportal 2025.07 data most carriageways omit it, and a default would mislabel them.

```csharp
public System.Nullable<DiGi.BDOT10k.Enums.OT_RodzajRepGeom> cechaGeometrii { get; set; }
```

#### Property Value
[System\.Nullable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')[OT\_RodzajRepGeom](DiGi.BDOT10k.Enums.md#DiGi.BDOT10k.Enums.OT_RodzajRepGeom 'DiGi\.BDOT10k\.Enums\.OT\_RodzajRepGeom')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')

<a name='DiGi.BDOT10k.Classes.OT_SKJZ_L.identyfikatorSIMC'></a>

## OT\_SKJZ\_L\.identyfikatorSIMC Property

Gets or sets the TERYT SIMC identifier of the locality the street lies in\.

```csharp
public string? identyfikatorSIMC { get; set; }
```

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.BDOT10k.Classes.OT_SKJZ_L.identyfikatorULIC'></a>

## OT\_SKJZ\_L\.identyfikatorULIC Property

Gets or sets the TERYT ULIC street identifier\.

```csharp
public string? identyfikatorULIC { get; set; }
```

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.BDOT10k.Classes.OT_SKJZ_L.ulicaCecha'></a>

## OT\_SKJZ\_L\.ulicaCecha Property

Gets or sets the street feature from TERYT, e\.g\. `ul.` or `pl.`\.

```csharp
public string? ulicaCecha { get; set; }
```

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.BDOT10k.Classes.OT_SKJZ_L.ulicaNazwa1'></a>

## OT\_SKJZ\_L\.ulicaNazwa1 Property

Gets or sets the first part of the street name from TERYT\.

```csharp
public string? ulicaNazwa1 { get; set; }
```

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.BDOT10k.Classes.OT_SKJZ_L.ulicaNazwa2'></a>

## OT\_SKJZ\_L\.ulicaNazwa2 Property

Gets or sets the second part of the street name from TERYT\.

```csharp
public string? ulicaNazwa2 { get; set; }
```

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.BDOT10k.Classes.OT_SKRP_L'></a>

## OT\_SKRP\_L Class

Pedestrian or cycle route \(`ciąg ruchu pieszego lub rowerowego`\) of the BDOT10k standard: alleys, promenades, footpaths and cycle paths\.

Derives directly from [OT\_ObiektTopograficzny](DiGi.BDOT10k.Classes.md#DiGi.BDOT10k.Classes.OT_ObiektTopograficzny 'DiGi\.BDOT10k\.Classes\.OT\_ObiektTopograficzny'), as in Annex 2 to Dz.U. 2021 poz. 1412.

```csharp
public class OT_SKRP_L : DiGi.BDOT10k.Classes.OT_ObiektTopograficzny, DiGi.BDOT10k.Interfaces.IOT_LiniowyObiektGeometryczny, DiGi.BDOT10k.Interfaces.IOT_ObiektGeometryczny<DiGi.GML.Classes.AbstractCurve>, DiGi.BDOT10k.Interfaces.IOT_ObiektGeometryczny, DiGi.GML.Interfaces.IAbstractGML, DiGi.GML.Interfaces.IFeatureMember
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.GML\.Classes\.AbstractGML](https://learn.microsoft.com/en-us/dotnet/api/digi.gml.classes.abstractgml 'DiGi\.GML\.Classes\.AbstractGML') → [DiGi\.GML\.Classes\.GML](https://learn.microsoft.com/en-us/dotnet/api/digi.gml.classes.gml 'DiGi\.GML\.Classes\.GML') → [OT\_ObiektTopograficzny](DiGi.BDOT10k.Classes.md#DiGi.BDOT10k.Classes.OT_ObiektTopograficzny 'DiGi\.BDOT10k\.Classes\.OT\_ObiektTopograficzny') → OT\_SKRP\_L

Implements [IOT\_LiniowyObiektGeometryczny](DiGi.BDOT10k.Interfaces.md#DiGi.BDOT10k.Interfaces.IOT_LiniowyObiektGeometryczny 'DiGi\.BDOT10k\.Interfaces\.IOT\_LiniowyObiektGeometryczny'), [DiGi\.BDOT10k\.Interfaces\.IOT\_ObiektGeometryczny&lt;](DiGi.BDOT10k.Interfaces.md#DiGi.BDOT10k.Interfaces.IOT_ObiektGeometryczny_T_ 'DiGi\.BDOT10k\.Interfaces\.IOT\_ObiektGeometryczny\<T\>')[DiGi\.GML\.Classes\.AbstractCurve](https://learn.microsoft.com/en-us/dotnet/api/digi.gml.classes.abstractcurve 'DiGi\.GML\.Classes\.AbstractCurve')[&gt;](DiGi.BDOT10k.Interfaces.md#DiGi.BDOT10k.Interfaces.IOT_ObiektGeometryczny_T_ 'DiGi\.BDOT10k\.Interfaces\.IOT\_ObiektGeometryczny\<T\>'), [IOT\_ObiektGeometryczny](DiGi.BDOT10k.Interfaces.md#DiGi.BDOT10k.Interfaces.IOT_ObiektGeometryczny 'DiGi\.BDOT10k\.Interfaces\.IOT\_ObiektGeometryczny'), [DiGi\.GML\.Interfaces\.IAbstractGML](https://learn.microsoft.com/en-us/dotnet/api/digi.gml.interfaces.iabstractgml 'DiGi\.GML\.Interfaces\.IAbstractGML'), [DiGi\.GML\.Interfaces\.IFeatureMember](https://learn.microsoft.com/en-us/dotnet/api/digi.gml.interfaces.ifeaturemember 'DiGi\.GML\.Interfaces\.IFeatureMember')
### Constructors

<a name='DiGi.BDOT10k.Classes.OT_SKRP_L.OT_SKRP_L()'></a>

## OT\_SKRP\_L\(\) Constructor

Initializes a new instance of the [OT\_SKRP\_L](DiGi.BDOT10k.Classes.md#DiGi.BDOT10k.Classes.OT_SKRP_L 'DiGi\.BDOT10k\.Classes\.OT\_SKRP\_L') class\.

```csharp
public OT_SKRP_L();
```
### Properties

<a name='DiGi.BDOT10k.Classes.OT_SKRP_L.geometria'></a>

## OT\_SKRP\_L\.geometria Property

Gets or sets the linear geometry of the object\.

```csharp
public DiGi.GML.Classes.AbstractCurve geometria { get; set; }
```

Implements [geometria](DiGi.BDOT10k.Interfaces.md#DiGi.BDOT10k.Interfaces.IOT_ObiektGeometryczny_T_.geometria 'DiGi\.BDOT10k\.Interfaces\.IOT\_ObiektGeometryczny\<T\>\.geometria')

#### Property Value
[DiGi\.GML\.Classes\.AbstractCurve](https://learn.microsoft.com/en-us/dotnet/api/digi.gml.classes.abstractcurve 'DiGi\.GML\.Classes\.AbstractCurve')

<a name='DiGi.BDOT10k.Classes.OT_SKRP_L.identyfikatorSIMC'></a>

## OT\_SKRP\_L\.identyfikatorSIMC Property

Gets or sets the TERYT SIMC identifier of the locality\.

```csharp
public string? identyfikatorSIMC { get; set; }
```

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.BDOT10k.Classes.OT_SKRP_L.identyfikatorULIC'></a>

## OT\_SKRP\_L\.identyfikatorULIC Property

Gets or sets the TERYT ULIC street identifier\.

```csharp
public string? identyfikatorULIC { get; set; }
```

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.BDOT10k.Classes.OT_SKRP_L.materialNawierzchni'></a>

## OT\_SKRP\_L\.materialNawierzchni Property

Gets or sets the surface material\.

```csharp
public System.Nullable<DiGi.BDOT10k.Enums.OT_MaterialNawierzchni> materialNawierzchni { get; set; }
```

#### Property Value
[System\.Nullable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')[OT\_MaterialNawierzchni](DiGi.BDOT10k.Enums.md#DiGi.BDOT10k.Enums.OT_MaterialNawierzchni 'DiGi\.BDOT10k\.Enums\.OT\_MaterialNawierzchni')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')

<a name='DiGi.BDOT10k.Classes.OT_SKRP_L.nazwa'></a>

## OT\_SKRP\_L\.nazwa Property

Gets or sets the proper name of the route\.

```csharp
public string? nazwa { get; set; }
```

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.BDOT10k.Classes.OT_SKRP_L.polozenie'></a>

## OT\_SKRP\_L\.polozenie Property

Gets or sets the position of the route relative to the ground surface\.

```csharp
public System.Nullable<DiGi.BDOT10k.Enums.OT_PolozenieObiektuSieciTransportowej> polozenie { get; set; }
```

#### Property Value
[System\.Nullable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')[OT\_PolozenieObiektuSieciTransportowej](DiGi.BDOT10k.Enums.md#DiGi.BDOT10k.Enums.OT_PolozenieObiektuSieciTransportowej 'DiGi\.BDOT10k\.Enums\.OT\_PolozenieObiektuSieciTransportowej')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')

<a name='DiGi.BDOT10k.Classes.OT_SKRP_L.rodzaj'></a>

## OT\_SKRP\_L\.rodzaj Property

Gets or sets the kind of route\.

```csharp
public System.Nullable<DiGi.BDOT10k.Enums.OT_RodzajCiaguRuchuPieszego> rodzaj { get; set; }
```

#### Property Value
[System\.Nullable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')[OT\_RodzajCiaguRuchuPieszego](DiGi.BDOT10k.Enums.md#DiGi.BDOT10k.Enums.OT_RodzajCiaguRuchuPieszego 'DiGi\.BDOT10k\.Enums\.OT\_RodzajCiaguRuchuPieszego')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')

<a name='DiGi.BDOT10k.Classes.OT_SKRP_L.szerokosc'></a>

## OT\_SKRP\_L\.szerokosc Property

Gets or sets the width in metres\.

```csharp
public System.Nullable<double> szerokosc { get; set; }
```

#### Property Value
[System\.Nullable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')

<a name='DiGi.BDOT10k.Classes.OT_SKRP_L.ulicaCecha'></a>

## OT\_SKRP\_L\.ulicaCecha Property

Gets or sets the street feature from TERYT, e\.g\. `ul.`\.

```csharp
public string? ulicaCecha { get; set; }
```

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.BDOT10k.Classes.OT_SKRP_L.ulicaNazwa1'></a>

## OT\_SKRP\_L\.ulicaNazwa1 Property

Gets or sets the first part of the street name from TERYT\.

```csharp
public string? ulicaNazwa1 { get; set; }
```

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.BDOT10k.Classes.OT_SKRP_L.ulicaNazwa2'></a>

## OT\_SKRP\_L\.ulicaNazwa2 Property

Gets or sets the second part of the street name from TERYT\.

```csharp
public string? ulicaNazwa2 { get; set; }
```

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')