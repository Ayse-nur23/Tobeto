import React, { useEffect, useState } from 'react'
import { Button, Card, Image } from 'semantic-ui-react'
import ProductService from '../services/ProductService'
import { useParams } from 'react-router-dom'

export default function ProductDetail() {

  let {id} = useParams()

  const [product, setProduct] = useState({}) //boş obje array almaz

  useEffect(() => {
    let productService = new ProductService()
    productService.getProductId(id).then(result=>setProduct(result.data))
  }, [id])
  
  return (
    <div>
      <Card.Group>
        <Card fluid>
          <Card.Content>
            <Image
              floated="right"
              size="mini"
              src="/images/avatar/large/steve.jpg"
            />
            <Card.Header>{product.productName}</Card.Header>
            <Card.Meta>{product.categoryName}</Card.Meta>
            <Card.Description>
              Steve wants to add you to the group <strong>best friends</strong>
            </Card.Description>
          </Card.Content>
          <Card.Content extra>
            <div className="ui two buttons">
              <Button basic color="green">
                Approve
              </Button>
              <Button basic color="red">
                Decline
              </Button>
            </div>
          </Card.Content>
        </Card>
      </Card.Group>
    </div>
  )
}
