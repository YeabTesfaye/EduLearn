import axios from "axios";

const BASE_URL = "http://localhost:5000/api";

interface LoginCredentials {
  email: string;
  password: string;
}

interface AuthResponse {
  id: string;
  email: string;
  name: string;
  role: string;
  token: string;
  refreshToken: string;
}

interface RegisterData extends LoginCredentials {
  name: string;
}

const authApi = axios.create({
  baseURL: BASE_URL,
  headers: {
    "Content-Type": "application/json",
  },
});

export const login = async (
  credentials: LoginCredentials
): Promise<AuthResponse> => {
  try {
    const response = await authApi.post<AuthResponse>(
      "/auth/login",
      credentials
    );
    return response.data;
  } catch (error) {
    if (axios.isAxiosError(error)) {
      throw new Error(error.response?.data?.message || "Failed to login");
    }
    throw error;
  }
};

export const register = async (
  userData: RegisterData
): Promise<AuthResponse> => {
  try {
    const response = await authApi.post<AuthResponse>(
      "/auth/register",
      userData
    );
    return response.data;
  } catch (error) {
    if (axios.isAxiosError(error)) {
      throw new Error(error.response?.data?.message || "Failed to register");
    }
    throw error;
  }
};

export const refreshToken = async (token: string): Promise<AuthResponse> => {
  try {
    const response = await authApi.post<AuthResponse>("/auth/refresh-token", {
      token,
    });
    return response.data;
  } catch (error) {
    if (axios.isAxiosError(error)) {
      throw new Error(
        error.response?.data?.message || "Failed to refresh token"
      );
    }
    throw error;
  }
};
