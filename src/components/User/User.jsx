import { useState, useEffect } from "react";

import { HeaderUser } from "./HeaderUser";
import { UserForm } from "./UserForm";
import { Estado } from "./Estado";

import { Ayuda } from "./Ayuda";
import JsonData from "../data/data.json";
import SmoothScroll from "smooth-scroll";
import "./User.css";
import { NavigationUser } from "./NavigationUser";

export const scroll = new SmoothScroll('a[href*="#"]', {
  speed: 1000,
  speedAsDuration: true,
});

const User = () => {
  const [landingPageData, setLandingPageData] = useState({});
  useEffect(() => {
    setLandingPageData(JsonData);
  }, []);

  return (
    <div>
      <NavigationUser />
      <HeaderUser data={landingPageData.HeaderUser} />
      <UserForm data={landingPageData.UserForm} />
      <h2>Estado</h2>
      <Estado data={landingPageData.Estado} />
      <Ayuda data={landingPageData.Ayuda} />
    </div>
  );
};

export default User;
