package org.json.alipay;

import java.io.BufferedReader;
import java.io.IOException;
import java.io.Reader;
import java.io.StringReader;

/* JADX INFO: loaded from: classes4.dex */
public class c {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    private int f4096a;
    private Reader b;
    private char c;
    private boolean d;

    public c(Reader reader) {
        this.b = reader.markSupported() ? reader : new BufferedReader(reader);
        this.d = false;
        this.f4096a = 0;
    }

    public c(String str) {
        this(new StringReader(str));
    }

    public String a(char c) throws JSONException {
        int i;
        StringBuffer stringBuffer = new StringBuffer();
        while (true) {
            char cB = b();
            if (cB == 0 || cB == '\n' || cB == '\r') {
                break;
            }
            if (cB == '\\') {
                cB = b();
                if (cB == 'b') {
                    cB = '\b';
                } else if (cB == 'f') {
                    cB = '\f';
                } else if (cB == 'n') {
                    stringBuffer.append('\n');
                } else if (cB != 'r') {
                    if (cB != 'x') {
                        if (cB != 't') {
                            i = cB == 'u' ? 4 : 2;
                        } else {
                            cB = '\t';
                        }
                    }
                    cB = (char) Integer.parseInt(a(i), 16);
                } else {
                    stringBuffer.append('\r');
                }
            } else if (cB == c) {
                return stringBuffer.toString();
            }
            stringBuffer.append(cB);
        }
        throw a("Unterminated string");
    }

    public String a(int i) throws JSONException {
        if (i == 0) {
            return "";
        }
        char[] cArr = new char[i];
        int i2 = 0;
        if (this.d) {
            this.d = false;
            cArr[0] = this.c;
            i2 = 1;
        }
        while (i2 < i) {
            try {
                int i3 = this.b.read(cArr, i2, i - i2);
                if (i3 == -1) {
                    break;
                }
                i2 += i3;
            } catch (IOException e) {
                throw new JSONException(e);
            }
        }
        this.f4096a += i2;
        if (i2 < i) {
            throw a("Substring bounds error");
        }
        this.c = cArr[i - 1];
        return new String(cArr);
    }

    public JSONException a(String str) {
        return new JSONException(str + toString());
    }

    public void a() {
        int i;
        if (this.d || (i = this.f4096a) <= 0) {
            throw new JSONException("Stepping back two steps is not supported");
        }
        this.f4096a = i - 1;
        this.d = true;
    }

    public char b() throws JSONException {
        if (this.d) {
            this.d = false;
            char c = this.c;
            if (c != 0) {
                this.f4096a++;
            }
            return c;
        }
        try {
            int i = this.b.read();
            if (i <= 0) {
                this.c = (char) 0;
                return (char) 0;
            }
            this.f4096a++;
            char c2 = (char) i;
            this.c = c2;
            return c2;
        } catch (IOException e) {
            throw new JSONException(e);
        }
    }

    public char c() {
        char cB;
        char cB2;
        while (true) {
            char cB3 = b();
            if (cB3 == '/') {
                char cB4 = b();
                if (cB4 == '*') {
                    while (true) {
                        char cB5 = b();
                        if (cB5 == 0) {
                            throw a("Unclosed comment");
                        }
                        if (cB5 == '*') {
                            if (b() == '/') {
                                break;
                            }
                            a();
                        }
                    }
                } else {
                    if (cB4 != '/') {
                        a();
                        return '/';
                    }
                    do {
                        cB = b();
                        if (cB == '\n' || cB == '\r') {
                            break;
                        }
                    } while (cB != 0);
                }
            } else if (cB3 == '#') {
                do {
                    cB2 = b();
                    if (cB2 == '\n' || cB2 == '\r') {
                        break;
                    }
                } while (cB2 != 0);
            } else if (cB3 == 0 || cB3 > ' ') {
                return cB3;
            }
        }
    }

    public Object d() {
        char c = c();
        if (c != '\"') {
            if (c != '[') {
                if (c == '{') {
                    a();
                    return new b(this);
                }
                if (c != '\'') {
                    if (c != '(') {
                        StringBuffer stringBuffer = new StringBuffer();
                        char cB = c;
                        while (cB >= ' ' && ",:]}/\\\"[{;=#".indexOf(cB) < 0) {
                            stringBuffer.append(cB);
                            cB = b();
                        }
                        a();
                        String strTrim = stringBuffer.toString().trim();
                        if (strTrim.equals("")) {
                            throw a("Missing value");
                        }
                        if (strTrim.equalsIgnoreCase("true")) {
                            return Boolean.TRUE;
                        }
                        if (strTrim.equalsIgnoreCase("false")) {
                            return Boolean.FALSE;
                        }
                        if (strTrim.equalsIgnoreCase("null")) {
                            return b.f4095a;
                        }
                        if ((c < '0' || c > '9') && c != '.' && c != '-' && c != '+') {
                            return strTrim;
                        }
                        if (c == '0') {
                            try {
                                return (strTrim.length() <= 2 || !(strTrim.charAt(1) == 'x' || strTrim.charAt(1) == 'X')) ? new Integer(Integer.parseInt(strTrim, 8)) : new Integer(Integer.parseInt(strTrim.substring(2), 16));
                            } catch (Exception unused) {
                            }
                        }
                        try {
                            try {
                                try {
                                    return new Integer(strTrim);
                                } catch (Exception unused2) {
                                    return new Double(strTrim);
                                }
                            } catch (Exception unused3) {
                                return new Long(strTrim);
                            }
                        } catch (Exception unused4) {
                            return strTrim;
                        }
                    }
                }
            }
            a();
            return new a(this);
        }
        return a(c);
    }

    public String toString() {
        return " at character " + this.f4096a;
    }
}
