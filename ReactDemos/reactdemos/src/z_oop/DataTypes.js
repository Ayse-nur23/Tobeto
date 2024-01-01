export default function DataTypes() {

    var number = 65;
    number = 53; //Ram'de number için yeni bir alan açılır, eski değerin(65) üzerine yazmaz yeni alan açılır.
    console.log(number) //65 Ram'de tutulmaya devam eder, number  artık yeni bir alanda 53 tutar.

    /*Primitive tiplerin Wrapper (kapsayıcı) türleri (String, Number, Boolean) obje olmalarına karşın immutable davranırlar. 
    Obje üzerindeki mevcut veri değiştirilemez ancak yeni metod veya değişken atanabilmektedir.*/


    var str1 = { x: 3 } //nesne oluşturulur
    var str2 = str1; // str2 'ye, str1'in refransı atanır.
    str1.x = 21 //eski değerin üzerine yazar, yeni alan açılmaz.
    console.log(str1, str2);
    str1 = { y: 56 } //yeni bir atama olduğu için Ram'da yeni bir alan açılack str1 artık y değerini tutacak, x ile herhangi bir bağlantısı olmayacak.
    str1.y = 98 // str2'i x'in bulunduğu referansa atandğı için str1 üzerindeki değişiklikler artık str2'yi etkilemez.
    console.log(str1, str2);


    /*Eşitlik ( = ) atamaları sadece obje türündeki bir değişkenin, başka bir değişkene atamasında referans olmaktadır. 
   Yeni bir value olduğunda her zaman için hafızada yeni bir alan açarlar.*/



    var sayi1 = 10;
    sayi1 = "Ayşenur Elmas"
    console.log(sayi1);

    //let birden fazla tanımlatmaz.

    let student = { id: 1, name: "Ayşenur" };
    console.log(student);


    function save(students, not = 10) {
        console.log(students.name + " : " + not)
    }
    save(student);
    save(student, 15);


    function saved(puan = 10, students) {
        console.log(students.name + " : " + puan)
    }
    //undefined : puan atanmadı olarak alır.
    saved(undefined, student);
    saved(15, student);



    let students = ["Engin Demiroğ", "Halit Kalaycı", "Engin Toprak"]
    console.log(students)

    let students2 = [students, { id: 2, name: "Halit" }, "Ankara", { city: "İstanbul" }]
    console.log(students2)
}
