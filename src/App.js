import "./App.css";
import { BrowserRouter as Router, Switch, Route } from "react-router-dom";
import Login from "./components/Login/Login";
import Register from "./components/Register/Register";
import { useSelector } from "react-redux";
import Home from "./components/Home/Home";
import User from "./components/User/User";
import Admin from "./components/Admin/Admin";
function App() {
  const state = useSelector((state) => state.UserReducer);
  return (
    <div className="App">
      <header className="App-header">
        <Router>
          <Switch>
            <Route path="/" exact>
              <Home />
            </Route>
            <Route path="/Register" exact>
              <Register />
            </Route>
            <Route path="/Login" exact>
              <Login />
            </Route>
            <Route path="/User" exact>
              <User />
            </Route>
            <Route path="/Admin" exact>
              <Admin />
            </Route>
          </Switch>
        </Router>
      </header>
    </div>
  );
}

export default App;
