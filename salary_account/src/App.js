import React from "react";
import Navbar from "./components/Navbar/Navbar";
import logo from './logomacwhite.png'

function App() {

  return (
      <header>
          <nav className="wrapper_navbar">
              <img src={logo} alt="photo" className="logo"/>
              <Navbar />
          </nav>
          <div className="content_header">
              <div className="wrapper_preview">
                  <h1 className="preview_title">Считай зарплату за пару кликов</h1>
                  <h4 className="preview_subtitle">Вместе с Макдоналдс</h4>
              </div>
              <div className="wrapper_photo">

              </div>
          </div>
      </header>
  );
}

export default App;
