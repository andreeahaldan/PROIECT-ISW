import { Link, useHistory } from "react-router-dom";

export default function Login() {
  return (
    <div>
      <div className="login-div">
        <h1 className="login">Login</h1>
        <div className="user-div">
          <div>
            <input
              className="text-input"
              type="text"
              placeholder="E-mail adress"
            />

            <input
              className="text-input"
              type="password"
              placeholder="Password"
            />
          </div>

          <button className="connect-input" type="submit">
            Connect
          </button>

          <div className="link-div">
            <Link to="" className="App-link">
              Forgot password?{" "}
            </Link>
          </div>

          <hr className="hr-text" data-content="OR" />
          <Link to="/register">
            <button className="connect-input register-button">
              Create new account
            </button>
          </Link>
        </div>
      </div>
    </div>
  );
}
