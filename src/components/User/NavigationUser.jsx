import { Link } from "react-router-dom";
export const NavigationUser = (props) => {
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
            Bienvenido
          </a>{" "}
        </div>

        <div
          className="collapse navbar-collapse"
          id="bs-example-navbar-collapse-1"
        >
          <ul className="nav navbar-nav navbar-right">
            <li>
              <a href="#UserForm" className="page-scroll">
                Solicitar
              </a>
            </li>

            <li>
              <a href="#Estado" className="page-scroll">
                Estado
              </a>
            </li>

            <li>
              <a href="#Ayuda" className="page-scroll">
                Ayuda
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
