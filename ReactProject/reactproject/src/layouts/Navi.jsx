import React, { useState } from 'react'
import CartSummary from './CartSummary'
import { Container, Menu } from 'semantic-ui-react'
import SignedOut from './SignedOut'
import SignedIn from './SignedIn'
import { useNavigate } from 'react-router-dom'

export default function Navi() {
    const [isAuthenticated, setIsAuthenticated] = useState(true)
    const navigate = useNavigate()

    function handleSignOut() { //çıkış yap kontolü
        setIsAuthenticated(false)
        navigate("/")
    }
    function handleSignIn() { //giriş yap kontolü
        setIsAuthenticated(true)
    }
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
                        {isAuthenticated ? <SignedIn signOut={handleSignOut} biset="1"/> : <SignedOut  signIn={handleSignIn}/>}
                    </Menu.Menu>
                </Container>
            </Menu>
        </div>
    )
}
