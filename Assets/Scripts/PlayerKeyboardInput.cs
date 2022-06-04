using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerKeyboardInput : MonoBehaviour
{
    public bool a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p, q, r, s, t, u, v, w, x, y, z, one, two, three, four, five, six, seven, eight, nine, zero, space, enter, backspace, leftShift, rightShift, leftControl, rightControl, tab, tilde = false;

    private void Update()
    {
        a = Input.GetKey(KeyCode.A);
        b = Input.GetKey(KeyCode.B);
        c = Input.GetKey(KeyCode.C);
        d = Input.GetKey(KeyCode.D);
        e = Input.GetKey(KeyCode.E);
        f = Input.GetKey(KeyCode.F);
        g = Input.GetKey(KeyCode.G);
        h = Input.GetKey(KeyCode.H);
        i = Input.GetKey(KeyCode.I);
        j = Input.GetKey(KeyCode.J);
        k = Input.GetKey(KeyCode.K);
        l = Input.GetKey(KeyCode.L);
        m = Input.GetKey(KeyCode.M);
        n = Input.GetKey(KeyCode.N);
        o = Input.GetKey(KeyCode.O);
        p = Input.GetKey(KeyCode.P);
        q = Input.GetKey(KeyCode.Q);
        r = Input.GetKey(KeyCode.R);
        s = Input.GetKey(KeyCode.S);
        t = Input.GetKey(KeyCode.T);
        u = Input.GetKey(KeyCode.U);
        v = Input.GetKey(KeyCode.V);
        w = Input.GetKey(KeyCode.W);
        x = Input.GetKey(KeyCode.X);
        y = Input.GetKey(KeyCode.Y);
        z = Input.GetKey(KeyCode.Z);
        zero = Input.GetKey(KeyCode.Alpha0);
        one = Input.GetKey(KeyCode.Alpha1);
        two = Input.GetKey(KeyCode.Alpha2);
        three = Input.GetKey(KeyCode.Alpha3);
        four = Input.GetKey(KeyCode.Alpha4);
        five = Input.GetKey(KeyCode.Alpha5);
        six = Input.GetKey(KeyCode.Alpha6);
        seven = Input.GetKey(KeyCode.Alpha7);
        eight = Input.GetKey(KeyCode.Alpha8);
        nine = Input.GetKey(KeyCode.Alpha9);
        space = Input.GetKey(KeyCode.Space);
        enter = Input.GetKey(KeyCode.Return);
        backspace = Input.GetKey(KeyCode.Backspace);
        leftShift = Input.GetKey(KeyCode.LeftShift);
        rightShift = Input.GetKey(KeyCode.RightShift);
        leftControl = Input.GetKey(KeyCode.LeftControl);
        rightControl = Input.GetKey(KeyCode.RightControl);
        tab = Input.GetKey(KeyCode.Tab);
        tilde = Input.GetKey(KeyCode.Tilde);
    }
}
