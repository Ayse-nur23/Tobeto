import React from 'react'
import { Grid } from 'semantic-ui-react'
import Categories from './Categories'
import ProductList from '../pages/ProductList'
import { Route, Routes } from 'react-router-dom'
import ProductDetail from '../pages/ProductDetail'
import CartDetail from '../pages/CartDetail'

export default function Dashboard() {
    return (
        <div>
            <Grid>
                <Grid.Row>
                    <Grid.Column width={4}>{/*semantic-ui sayfayı(grid sistemi) 16 parçaya böler*/}
                        <Categories />
                    </Grid.Column>
                    <Grid.Column width={12}>
                        <Routes>
                            <Route path="/" Component={ProductList} />
                            <Route path="/products" Component={ProductList} />
                            <Route path="/products/:id" Component={ProductDetail} />
                            <Route path="/cart" Component={CartDetail} />

                        </Routes>
                    </Grid.Column>
                </Grid.Row>
            </Grid>
        </div>
    )
}
