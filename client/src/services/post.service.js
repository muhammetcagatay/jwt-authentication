import axios from "axios";
import authHeader from "./auth-header";

const baseURL = "https://localhost:5001";

const API_URL = "/api/home";

const getAllPrivatePosts = () => {
  return axios.get(baseURL+API_URL, { headers: authHeader() });
};

const postService = {
  getAllPrivatePosts,
};

export default postService;