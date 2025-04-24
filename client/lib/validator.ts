import { z } from "zod";

// Schema for signing in a user
export const signInFormSchema = z.object({
  email: z
    .string()
    .trim()
    .min(1, { message: "Email required!" })
    .email({ message: "Invalid email!" }),
  password: z
    .string()
    .trim()
    .min(1, { message: "Password required!" })
    .min(6, { message: "Password must have at least 8 characters!" }),
});

// Schema for siging up a user
export const signUpFormSchema = z
  .object({
    name: z
      .string()
      .min(3, "Name must be at least 3 characters")
      .regex(/^[a-zA-Z\s]+$/, {
        message: "Name must contain only letters and spaces",
      }),
    email: z
      .string()
      .min(3, "Email Must be at least 3 characters")
      .email("Please provide a valid email address"),
    password: z
      .string()
      .min(6, "Password must be at least 6 characters")
      .max(64, "Password can't be longer than 64 characters")
      .regex(/^[a-zA-Z0-9!@#$%^&*()_+={}\[\]:;<>,.?/~`-]+$/, {
        message: "Password contains invalid characters",
      }),
    confirmPassword: z.string(),
  })
  .refine((data) => data.password === data.confirmPassword, {
    message: "Passwords don't match",
    path: ["confirmPassword"],
  });
