import React from 'react'
import { Dropdown, Menu } from 'semantic-ui-react'

export default function CartSummary() {
    return (
        <div>
            <Dropdown item text='Sepet'>
                <Dropdown.Menu>
                    <Dropdown.Item>Sepet</Dropdown.Item>
                    <Dropdown.Item>Sepet</Dropdown.Item>
                    <Dropdown.Item>Sepet</Dropdown.Item>
                </Dropdown.Menu>
            </Dropdown>
        </div>
    )
}
