export default function RestSpreadDestructure() {
 /*rest: parametreyi array olarak alır*/
let showProducts = function (id, ...products) {
    console.log(id)
    //console.log(products[0])
    console.log(products)
}

 console.log(typeof showProducts)
// showProducts()
// showProducts(1, "kalem", "defter", "silgi")
// showProducts(2, ["kalem", "defter", "silgi"])


/*spread : array'i parametre gibi ayırır, array ayrıştırır*/
let points = [1, 2, 3, 98, 27, 32, 18]
console.log(...points)
console.log(Math.max(...points))
console.log(..."ABC", "D", ..."EFG", "H")

//Destructuring
let populations = [10000, 20000, 30000, [40000, 1000]]
let [small, medium, high, [veryHigh, maximum]] = populations
console.log(small);
console.log(medium);
console.log(high);
console.log(veryHigh);
console.log(maximum);

function someFunction([small1], number){
    console.log([small1])
}

someFunction(populations)


let category = {id: 1, name : "İçecek"}
console.log(category.id)
console.log(category["name"])
console.log(category.name)

let {id, name} = category
console.log(id)
console.log(name);
}



