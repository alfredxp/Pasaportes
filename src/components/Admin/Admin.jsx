import { useState, useEffect } from "react";

import JsonData from "../data/data.json";
import SmoothScroll from "smooth-scroll";
import "./Admin.css";
import { AdminNavegation } from "./AdminNavegation";
import { Usuarios } from "./Usuarios";
import { Impuesto } from "./Impuestos";
import { Oficinas } from "./Oficinas";
import { AdminHeader } from "./AdminHeader";

export const scroll = new SmoothScroll('a[href*="#"]', {
  speed: 1000,
  speedAsDuration: true,
});

const Admin = () => {
  const [landingPageData, setLandingPageData] = useState({});
  useEffect(() => {
    setLandingPageData(JsonData);
  }, []);

  return (
    <div>
      <AdminNavegation />
      <AdminHeader data={landingPageData.AdminHeader} />
      <h2>Usuarios</h2>
      <Usuarios data={landingPageData.Usuarios} />
      <h2>Impuestos</h2>
      <Impuesto data={landingPageData.Impuesto} />
      <h2>Oficinas</h2>
      <Oficinas data={landingPageData.Oficinas} />
    </div>
  );
};

export default Admin;
