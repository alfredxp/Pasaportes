import { Link } from "react-router-dom";
export const AdminNavegation = (props) => {
  return (
    <nav id="menu" className="navbar navbar-default navbar-fixed-top">
      <div className="container">
        <div className="navbar-header">
          <button
            type="button"
            className="navbar-toggle collapsed"
            data-toggle="collapse"
            data-target="#bs-example-navbar-collapse-1"
          >
            {" "}
            <span className="sr-only">Toggle navigation</span>{" "}
            <span className="icon-bar"></span>{" "}
            <span className="icon-bar"></span>{" "}
            <span className="icon-bar"></span>{" "}
          </button>
          <a className="navbar-brand page-scroll" href="#page-top">
            Bienvenido Admin
          </a>{" "}
        </div>

        <div
          className="collapse navbar-collapse"
          id="bs-example-navbar-collapse-1"
        >
          <ul className="nav navbar-nav navbar-right">
            <li>
              <a href="#Usuarios" className="page-scroll">
                Usuarios
              </a>
            </li>

            <li>
              <a href="#Impuestos" className="page-scroll">
                Impuestos
              </a>
            </li>

            <li>
              <a href="#AyOficinasuda" className="page-scroll">
                Oficinas
              </a>
            </li>
            <li>
              <Link className="link" to="/Login">
                Sign Out
              </Link>
            </li>
          </ul>
        </div>
      </div>
    </nav>
  );
};
