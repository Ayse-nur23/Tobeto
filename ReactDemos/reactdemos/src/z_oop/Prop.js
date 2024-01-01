export default function Prop() {
    class Customer {
        constructor(id, customerNumber, salary) {
            this.id = id;
            this.customerNumber = customerNumber;
            this.salary = salary;
        }
    }
    
    let customer1 = new Customer(1, "12345");
    
    //instance prototyping : nesneye başka bir özellik ekleyip kullanılabilir.
    customer1.name = "Murat Kurtboğan";
    console.log(customer1.name);
    
    //class prototyping : nesneye başka bir özellik ekleyip kullanılabilir.
    Customer.bisey = "Bisey"
    console.log(Customer.bisey);
    
    console.log(customer1.id, customer1.customerNumber)
    
    
    class IndividualCustomer extends Customer {
        constructor(firstName, id, customerNumber) {
            super(id, customerNumber)
            this.firstName = firstName
        }
    }
    
    class CorporateCustomer extends Customer {
        constructor(companyName, id, customerNumber) {
            super(id, customerNumber)
            this.companyName = companyName
        }
    }
    CorporateCustomer.companyName = "Tobeto"
    IndividualCustomer.firstName = "Ayşenur"
}
