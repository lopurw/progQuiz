﻿namespace progQuiz.API.Interfaces.Auth;

public interface IPasswordHasher
{
    public string Generate(string password);
    public bool Verify(string password, string hashedPassword);
}