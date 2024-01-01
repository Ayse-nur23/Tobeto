import React, { useState } from 'react'
import CartSummary from './CartSummary'
import { Container, Menu } from 'semantic-ui-react'
import SignedOut from './SignedOut'
import SignedIn from './SignedIn'

export default function Navi() {
    const [isAuthenticated, setIsAuthenticated] = useState(true)
    return (
        <div>
            <Menu inverted fixed='top' >{/*inverted : arkaplan siyah yapar,  fixed='top' : aşağı gidildikçe menü de hareket eder*/}
                <Container>
                    <Menu.Item
                        name='home'
                    />
                    <Menu.Item
                        name='messages'
                    />
                    <Menu.Menu position='right'>
                        <CartSummary />
                        {isAuthenticated ? <SignedIn/> :<SignedOut />}
                    </Menu.Menu>
                </Container>
            </Menu>
        </div>
    )
}
