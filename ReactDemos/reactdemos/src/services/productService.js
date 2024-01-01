import axios from "axios";

export default class ProductService {
  getProduct() {
    return axios.get('http://localhost:40408/api/Products/getList?PageIndex=0&PageSize=10' );
  }
}
