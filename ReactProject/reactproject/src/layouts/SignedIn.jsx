import React from 'react'
import { Dropdown, Image, Menu } from 'semantic-ui-react'

export default function SignedIn() {
    return (
        <div>
            <Menu.Item>
                <Image avatar spaced="right" src="https://react.semantic-ui.com/logo.png" />
                <Dropdown pointing="top left" text='Ayşenur'>
                    <Dropdown.Menu>
                        <Dropdown.Item text="Bilgilerim" icon="info" />
                        <Dropdown.Item text="Çıkış Yap" icon="sign-out" />
                    </Dropdown.Menu>
                </Dropdown>
            </Menu.Item>
        </div>
    )
}
