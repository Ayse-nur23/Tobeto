export default function MapFilterReduce() {

    let customers = [
        { id: 1, customerNumber: "12345", salary: 12000 },
        { id: 2, customerNumber: "45432", salary: 15000 },
        { id: 3, customerNumber: "11243", salary: 1200 },
        { id: 4, customerNumber: "57546", salary: 18000 },
        { id: 5, customerNumber: "43546", salary: 19000 },
        { id: 6, customerNumber: "57678", salary: 20000 },
        { id: 7, customerNumber: "44343", salary: 21000 }
    ]
    
    console.log("<ul>")
    customers.map(customer => console.log(`<li>${customer.customerNumber}</li> `))
    console.log("</ul>")
    

    customers.map(customer => {
        console.log(customer)
        console.log(`<li>${customer.customerNumber}</li> `)
    })

    let filteredCustomers = customers.filter(customer => customer.salary < 19000)
    console.log(filteredCustomers)
    
    let salaryTotal = customers.reduce((acc, customer) => acc + customer.salary, 0)
    console.log(salaryTotal)
    
    let salaryTotal2 = customers.filter(customer => customer.salary < 19000)
        .map(c=>{
            c.salary = c.salary * 1.18
           return c
        }).reduce((acc, c) => acc + c.salary, 0)
    console.log(salaryTotal2)
}
