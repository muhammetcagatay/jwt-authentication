import React, { useState, useEffect } from "react";
import PostService from "../services/post.service";
import AuthService from "../services/auth.service";
import { useNavigate, Link } from "react-router-dom";
import Alert from 'react-bootstrap/Alert';

const Home = () => {
  const [privatePosts, setPrivatePosts] = useState([]);
  const user = AuthService.getCurrentUser();
  const logOut = () => {
    AuthService.logout();
  };

  const navigate = useNavigate();

  useEffect(() => {
    PostService.getAllPrivatePosts().then(
      (response) => {
        setPrivatePosts(response.data);
      },
      async (error) => {
        // Invalid token
        if (error.response == null) {
          //refresh token
          if (user != null) {
            await AuthService.loginWithRefreshToken(user.refreshToken).then(
              () => {
                navigate("/private");
                window.location.reload();
              },
              () => {
                AuthService.logout();
                navigate("/");
                window.location.reload();
              }
            );
          } else {
            AuthService.logout();
            navigate("/");
            window.location.reload();
          }
        }
      }
    );
  }, [user, navigate]);

  return (
    <div>
      <Alert severity="success">
        <Alert.Heading>Success</Alert.Heading>
        {privatePosts}
      </Alert>

      <div className="d-grid gap-2 mt-3">
        <Link to="/" onClick={logOut}>

          <button type="submit" className="btn btn-primary">
            Logout
          </button>
        </Link>
      </div>
    </div>
  );
};

export default Home;