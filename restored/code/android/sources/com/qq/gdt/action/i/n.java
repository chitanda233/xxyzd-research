package com.qq.gdt.action.i;

import org.json.JSONException;
import org.json.JSONObject;

/* JADX INFO: loaded from: classes3.dex */
public class n {
    /* JADX WARN: Code duplicated, block: B:23:0x003f A[DONT_INVERT] */
    /* JADX WARN: Code duplicated, block: B:24:0x0041 A[Catch: Exception -> 0x0074, TryCatch #0 {Exception -> 0x0074, blocks: (B:4:0x0004, B:7:0x000c, B:8:0x0015, B:10:0x001b, B:22:0x003b, B:34:0x006b, B:24:0x0041, B:25:0x004a, B:27:0x004f, B:28:0x0058, B:31:0x005f, B:33:0x0068, B:35:0x006f), top: B:39:0x0004 }] */
    public static String a(String str) {
        if (str != null) {
            try {
                if (!"".equals(str)) {
                    StringBuilder sb = new StringBuilder();
                    int i = 0;
                    char c = 0;
                    boolean z = false;
                    int i2 = 0;
                    while (i < str.length()) {
                        char cCharAt = str.charAt(i);
                        if (cCharAt != '\"') {
                            if (cCharAt != ',') {
                                if (cCharAt != '[') {
                                    if (cCharAt == ']') {
                                        if (!z) {
                                            sb.append('\n');
                                            i2--;
                                            a(sb, i2);
                                        }
                                    } else if (cCharAt != '{') {
                                        if (cCharAt == '}') {
                                            if (!z) {
                                                sb.append('\n');
                                                i2--;
                                                a(sb, i2);
                                            }
                                        }
                                    }
                                }
                                sb.append(cCharAt);
                                if (!z) {
                                    sb.append('\n');
                                    i2++;
                                    a(sb, i2);
                                }
                            } else {
                                sb.append(cCharAt);
                                if (c != '\\' && !z) {
                                    sb.append('\n');
                                    a(sb, i2);
                                }
                            }
                            i++;
                            c = cCharAt;
                        } else if (c != '\\') {
                            z = !z;
                        }
                        sb.append(cCharAt);
                        i++;
                        c = cCharAt;
                    }
                    return sb.toString();
                }
            } catch (Exception unused) {
            }
        }
        return "";
    }

    public static JSONObject a(String str, int i) {
        JSONObject jSONObject = new JSONObject();
        try {
            jSONObject.putOpt(str, Integer.valueOf(i));
        } catch (JSONException e) {
            e.printStackTrace();
        }
        return jSONObject;
    }

    private static void a(StringBuilder sb, int i) {
        for (int i2 = 0; i2 < i; i2++) {
            try {
                sb.append('\t');
            } catch (Exception e) {
                e.printStackTrace();
                return;
            }
        }
    }

    public static boolean a(JSONObject jSONObject) {
        return jSONObject == null || jSONObject.length() <= 0;
    }
}
