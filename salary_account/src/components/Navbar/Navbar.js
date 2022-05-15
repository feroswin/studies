import React from "react";

export default function Navbar() {
    return (
        <ul className="navbar">
            <li className="navbar_item"><a href="#" className="link_nav">О нас</a></li>
            <li className="navbar_item"><a href="#" className="link_nav">Зачем это?</a></li>
            <li className="navbar_item"><a href="#" className="link_nav">Подписки</a></li>
            <li className="navbar_item"><a href="#" className="link_nav">Блог</a></li>
            <li className="navbar_item"><input type="button" value="Войти" className="btn-login"/></li>
        </ul>
    )
}