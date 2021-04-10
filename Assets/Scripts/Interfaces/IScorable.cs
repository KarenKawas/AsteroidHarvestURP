using UnityEngine;

public interface IScorable
{
    int ScoreValue { get; }

    void AddScore();
}
