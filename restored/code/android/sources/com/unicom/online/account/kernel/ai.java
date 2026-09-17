package com.unicom.online.account.kernel;

import android.content.Context;
import android.net.Network;
import android.net.Uri;
import android.text.TextUtils;
import android.util.Base64;
import com.byazt.nys.PluginConstants;
import java.io.ByteArrayOutputStream;
import java.io.IOException;
import java.io.InputStream;
import java.io.OutputStream;
import java.net.HttpURLConnection;
import java.net.MalformedURLException;
import java.net.URL;
import java.util.HashMap;
import java.util.Locale;
import java.util.concurrent.atomic.AtomicBoolean;
import org.json.JSONObject;

/* JADX INFO: loaded from: classes4.dex */
public abstract class ai {
    /* JADX WARN: Code duplicated, block: B:125:0x0211  */
    /* JADX WARN: Code duplicated, block: B:127:0x0215  */
    /* JADX WARN: Code duplicated, block: B:134:0x022f  */
    /* JADX WARN: Code duplicated, block: B:138:0x0235  */
    /* JADX WARN: Code duplicated, block: B:141:0x0244  */
    /* JADX WARN: Code duplicated, block: B:149:0x01d2 A[EXC_TOP_SPLITTER, SYNTHETIC] */
    /* JADX WARN: Code duplicated, block: B:187:0x0247 A[SYNTHETIC] */
    /* JADX WARN: Code duplicated, block: B:188:0x0228 A[SYNTHETIC] */
    /* JADX WARN: Code duplicated, block: B:189:0x024e A[EDGE_INSN: B:189:0x024e->B:145:0x024e BREAK  A[LOOP:0: B:3:0x0014->B:200:0x0014], SYNTHETIC] */
    /* JADX WARN: Code duplicated, block: B:191:0x021f A[SYNTHETIC] */
    /* JADX WARN: Code duplicated, block: B:192:0x024e A[EDGE_INSN: B:192:0x024e->B:145:0x024e BREAK  A[LOOP:0: B:3:0x0014->B:200:0x0014], SYNTHETIC] */
    /* JADX WARN: Code duplicated, block: B:202:0x0014 A[SYNTHETIC] */
    /* JADX WARN: Code duplicated, block: B:203:0x0014 A[SYNTHETIC] */
    public static String b(Context context, String str, HashMap map, Object obj, az azVar) {
        int i;
        String string;
        ax axVarB;
        String strB;
        JSONObject jSONObject;
        int i2;
        String strB2;
        JSONObject jSONObject2;
        String str2 = str;
        Object obj2 = obj;
        Boolean bool = Boolean.FALSE;
        int i3 = 0;
        String str3 = null;
        while (azVar.b <= 2) {
            int i4 = 410011;
            try {
                String str4 = "callDepth";
                String str5 = "requestUrl:";
                String str6 = "请求超时";
                try {
                    try {
                        if (!Thread.currentThread().isInterrupted() && !azVar.g.get()) {
                            if (bool.booleanValue()) {
                                str6 = "请求超时";
                                str5 = "requestUrl:";
                                str4 = "callDepth";
                                i4 = 410011;
                                i2 = i3;
                            } else {
                                try {
                                    s sVar = azVar.f;
                                    Thread.currentThread().getId();
                                    Thread.currentThread().getName();
                                    if (str2.startsWith("https")) {
                                        i4 = 410011;
                                        i2 = i3;
                                        try {
                                            strB2 = b(context, str2, map, obj2, sVar, i3, azVar.g);
                                        } catch (Exception e) {
                                            e = e;
                                            i3 = i2;
                                            i = 2;
                                        }
                                    } else {
                                        i4 = 410011;
                                        i2 = i3;
                                        strB2 = b(context, str2, map, obj2, i2, azVar.g);
                                    }
                                    str3 = strB2;
                                } catch (Exception e2) {
                                    e = e2;
                                    i = 2;
                                }
                            }
                            str3 = str3;
                            try {
                                bool = Boolean.FALSE;
                                try {
                                    try {
                                        try {
                                            if (!Thread.currentThread().isInterrupted()) {
                                                try {
                                                    if (!azVar.g.get()) {
                                                        if (str3 != null) {
                                                            try {
                                                                int iOptInt = new JSONObject(str3).optInt(PluginConstants.KEY_ERROR_CODE, 0);
                                                                if (iOptInt != 0 && iOptInt != 100) {
                                                                    if (iOptInt != i4 && iOptInt != 410012 && iOptInt != 410013 && iOptInt != 410010) {
                                                                        if (iOptInt == 1102) {
                                                                            azVar.d = null;
                                                                        }
                                                                    }
                                                                    i = 2;
                                                                    if (azVar.b != 2) {
                                                                        try {
                                                                            ay ayVarB = az.b(str3);
                                                                            if (ayVarB != null) {
                                                                                String str7 = ayVarB.b;
                                                                                try {
                                                                                    i3 = ayVarB.c;
                                                                                    str2 = str7;
                                                                                } catch (Exception e3) {
                                                                                    e = e3;
                                                                                    str2 = str7;
                                                                                    i3 = i2;
                                                                                    e.getMessage();
                                                                                    if (azVar.b == i) {
                                                                                        try {
                                                                                            JSONObject jSONObject3 = new JSONObject();
                                                                                            jSONObject3.put(PluginConstants.KEY_ERROR_CODE, i4);
                                                                                            jSONObject3.put("msg", "https异常: " + e.getMessage());
                                                                                            jSONObject3.put("data", "requestUrl->" + str2);
                                                                                            string = jSONObject3.toString();
                                                                                            return string;
                                                                                        } catch (Exception unused) {
                                                                                            return null;
                                                                                        }
                                                                                    }
                                                                                    if (azVar.c != null) {
                                                                                        axVarB = azVar.b(obj2);
                                                                                        obj2 = axVarB.b;
                                                                                        if (axVarB.c) {
                                                                                            az.b(azVar.f, obj2);
                                                                                            if (i3 != i) {
                                                                                                azVar.d = null;
                                                                                            } else {
                                                                                                azVar.d = null;
                                                                                            }
                                                                                            strB = azVar.b(str2, azVar.h);
                                                                                            if (!str2.equals(strB)) {
                                                                                                str2 = strB;
                                                                                                i3 = 0;
                                                                                            }
                                                                                            if (!azVar.b()) {
                                                                                                break;
                                                                                                return str3;
                                                                                            }
                                                                                        } else {
                                                                                            bool = Boolean.TRUE;
                                                                                            if (!azVar.b()) {
                                                                                                break;
                                                                                                return str3;
                                                                                            }
                                                                                        }
                                                                                    } else if (!azVar.b()) {
                                                                                        break;
                                                                                        return str3;
                                                                                    }
                                                                                }
                                                                            } else {
                                                                                i3 = i2;
                                                                            }
                                                                            try {
                                                                                if (azVar.c != null) {
                                                                                    ax axVarB2 = azVar.b(obj2);
                                                                                    obj2 = axVarB2.b;
                                                                                    if (axVarB2.c) {
                                                                                        az.b(azVar.f, obj2);
                                                                                        if (i3 == 2 || i3 == 3) {
                                                                                            azVar.d = null;
                                                                                        }
                                                                                        String strB3 = azVar.b(str2, azVar.h);
                                                                                        if (!str2.equals(strB3)) {
                                                                                            str2 = strB3;
                                                                                            i3 = 0;
                                                                                        }
                                                                                    } else {
                                                                                        bool = Boolean.TRUE;
                                                                                        if (azVar.b()) {
                                                                                            str3 = str3;
                                                                                        }
                                                                                    }
                                                                                }
                                                                                str3 = str3;
                                                                            } catch (Exception e4) {
                                                                                e = e4;
                                                                                str3 = str3;
                                                                                e.getMessage();
                                                                                if (azVar.b == i) {
                                                                                    JSONObject jSONObject4 = new JSONObject();
                                                                                    jSONObject4.put(PluginConstants.KEY_ERROR_CODE, i4);
                                                                                    jSONObject4.put("msg", "https异常: " + e.getMessage());
                                                                                    jSONObject4.put("data", "requestUrl->" + str2);
                                                                                    string = jSONObject4.toString();
                                                                                    return string;
                                                                                }
                                                                                if (azVar.c != null) {
                                                                                    axVarB = azVar.b(obj2);
                                                                                    obj2 = axVarB.b;
                                                                                    if (axVarB.c) {
                                                                                        bool = Boolean.TRUE;
                                                                                        if (!azVar.b()) {
                                                                                            break;
                                                                                            return str3;
                                                                                        }
                                                                                    } else {
                                                                                        az.b(azVar.f, obj2);
                                                                                        if (i3 != i) {
                                                                                            azVar.d = null;
                                                                                        } else {
                                                                                            azVar.d = null;
                                                                                        }
                                                                                        strB = azVar.b(str2, azVar.h);
                                                                                        if (!str2.equals(strB)) {
                                                                                            str2 = strB;
                                                                                            i3 = 0;
                                                                                        }
                                                                                        if (!azVar.b()) {
                                                                                            break;
                                                                                            return str3;
                                                                                        }
                                                                                    }
                                                                                } else if (!azVar.b()) {
                                                                                    break;
                                                                                    return str3;
                                                                                }
                                                                            }
                                                                        } catch (Exception e5) {
                                                                            e = e5;
                                                                            i3 = i2;
                                                                            e.getMessage();
                                                                            if (azVar.b == i) {
                                                                                JSONObject jSONObject5 = new JSONObject();
                                                                                jSONObject5.put(PluginConstants.KEY_ERROR_CODE, i4);
                                                                                jSONObject5.put("msg", "https异常: " + e.getMessage());
                                                                                jSONObject5.put("data", "requestUrl->" + str2);
                                                                                string = jSONObject5.toString();
                                                                                return string;
                                                                            }
                                                                            if (azVar.c != null) {
                                                                                axVarB = azVar.b(obj2);
                                                                                obj2 = axVarB.b;
                                                                                if (axVarB.c) {
                                                                                    bool = Boolean.TRUE;
                                                                                    if (!azVar.b()) {
                                                                                        break;
                                                                                        return str3;
                                                                                    }
                                                                                } else {
                                                                                    az.b(azVar.f, obj2);
                                                                                    if (i3 != i) {
                                                                                        azVar.d = null;
                                                                                    } else {
                                                                                        azVar.d = null;
                                                                                    }
                                                                                    strB = azVar.b(str2, azVar.h);
                                                                                    if (!str2.equals(strB)) {
                                                                                        str2 = strB;
                                                                                        i3 = 0;
                                                                                    }
                                                                                    if (!azVar.b()) {
                                                                                        break;
                                                                                        return str3;
                                                                                    }
                                                                                }
                                                                            } else if (!azVar.b()) {
                                                                                break;
                                                                                return str3;
                                                                            }
                                                                        }
                                                                        if (!azVar.b()) {
                                                                            break;
                                                                        }
                                                                    }
                                                                }
                                                            } catch (Exception unused2) {
                                                            }
                                                        }
                                                        return str3;
                                                    }
                                                } catch (Exception e6) {
                                                    e = e6;
                                                    i = 2;
                                                }
                                                e = e4;
                                                str3 = str3;
                                                e.getMessage();
                                                if (azVar.b == i) {
                                                    JSONObject jSONObject6 = new JSONObject();
                                                    jSONObject6.put(PluginConstants.KEY_ERROR_CODE, i4);
                                                    jSONObject6.put("msg", "https异常: " + e.getMessage());
                                                    jSONObject6.put("data", "requestUrl->" + str2);
                                                    string = jSONObject6.toString();
                                                    return string;
                                                }
                                                if (azVar.c != null) {
                                                    axVarB = azVar.b(obj2);
                                                    obj2 = axVarB.b;
                                                    if (axVarB.c) {
                                                        bool = Boolean.TRUE;
                                                        if (!azVar.b()) {
                                                            break;
                                                        }
                                                    } else {
                                                        az.b(azVar.f, obj2);
                                                        if (i3 != i || i3 == 3) {
                                                            azVar.d = null;
                                                        }
                                                        strB = azVar.b(str2, azVar.h);
                                                        if (!str2.equals(strB)) {
                                                            str2 = strB;
                                                            i3 = 0;
                                                        }
                                                        if (!azVar.b()) {
                                                            break;
                                                            break;
                                                        }
                                                    }
                                                } else if (!azVar.b()) {
                                                    break;
                                                    break;
                                                }
                                            }
                                            jSONObject2.put(str4, i3);
                                            string = jSONObject2.toString();
                                        } catch (Exception e7) {
                                            e = e7;
                                            e.getMessage();
                                            return null;
                                        }
                                        jSONObject2.put(PluginConstants.KEY_ERROR_CODE, 410000);
                                        jSONObject2.put("msg", str6);
                                        jSONObject2.put("data", str5 + str2);
                                        i3 = i2;
                                    } catch (Exception e8) {
                                        e = e8;
                                        i3 = i2;
                                    }
                                    jSONObject2 = new JSONObject();
                                } catch (Exception e9) {
                                    e = e9;
                                    i3 = i2;
                                    str3 = str3;
                                    e.getMessage();
                                    if (azVar.b == i) {
                                        JSONObject jSONObject7 = new JSONObject();
                                        jSONObject7.put(PluginConstants.KEY_ERROR_CODE, i4);
                                        jSONObject7.put("msg", "https异常: " + e.getMessage());
                                        jSONObject7.put("data", "requestUrl->" + str2);
                                        string = jSONObject7.toString();
                                    } else if (azVar.c != null) {
                                        axVarB = azVar.b(obj2);
                                        obj2 = axVarB.b;
                                        if (axVarB.c) {
                                            bool = Boolean.TRUE;
                                            if (!azVar.b()) {
                                                break;
                                                return str3;
                                            }
                                        } else {
                                            az.b(azVar.f, obj2);
                                            if (i3 != i) {
                                                azVar.d = null;
                                            } else {
                                                azVar.d = null;
                                            }
                                            strB = azVar.b(str2, azVar.h);
                                            if (!str2.equals(strB)) {
                                                str2 = strB;
                                                i3 = 0;
                                            }
                                            if (!azVar.b()) {
                                                break;
                                                return str3;
                                            }
                                        }
                                    } else if (!azVar.b()) {
                                        break;
                                        return str3;
                                    }
                                }
                                i = 2;
                            } catch (Exception e10) {
                                e = e10;
                                i3 = i2;
                                i = 2;
                            }
                            return string;
                        }
                        jSONObject.put(PluginConstants.KEY_ERROR_CODE, 410000);
                        jSONObject.put("msg", "请求超时");
                        jSONObject.put("data", "requestUrl:" + str2);
                        jSONObject.put("callDepth", i3);
                        string = jSONObject.toString();
                        return string;
                    } catch (Exception e11) {
                        e11.getMessage();
                        return null;
                    }
                    jSONObject = new JSONObject();
                } catch (Exception e12) {
                    e = e12;
                    e.getMessage();
                    if (azVar.b == i) {
                        JSONObject jSONObject8 = new JSONObject();
                        jSONObject8.put(PluginConstants.KEY_ERROR_CODE, i4);
                        jSONObject8.put("msg", "https异常: " + e.getMessage());
                        jSONObject8.put("data", "requestUrl->" + str2);
                        string = jSONObject8.toString();
                    } else if (azVar.c != null) {
                        axVarB = azVar.b(obj2);
                        obj2 = axVarB.b;
                        if (axVarB.c) {
                            bool = Boolean.TRUE;
                            if (!azVar.b()) {
                                break;
                                return str3;
                            }
                        } else {
                            az.b(azVar.f, obj2);
                            if (i3 != i) {
                                azVar.d = null;
                            } else {
                                azVar.d = null;
                            }
                            strB = azVar.b(str2, azVar.h);
                            if (!str2.equals(strB)) {
                                str2 = strB;
                                i3 = 0;
                            }
                            if (!azVar.b()) {
                                break;
                                return str3;
                            }
                        }
                    } else if (!azVar.b()) {
                        break;
                        return str3;
                    }
                }
                i4 = 410011;
                i = 2;
            } catch (Exception e13) {
                e = e13;
            }
        }
        return str3;
    }

    /*  JADX ERROR: Types fix failed
        jadx.core.utils.exceptions.JadxOverflowException: Type inference error: updates count limit reached with updateSeq = 11901. Try increasing type updates limit count.
        	at jadx.core.utils.ErrorsCounter.addError(ErrorsCounter.java:59)
        	at jadx.core.utils.ErrorsCounter.error(ErrorsCounter.java:31)
        	at jadx.core.dex.attributes.nodes.NotificationAttrNode.addError(NotificationAttrNode.java:19)
        	at jadx.core.dex.visitors.typeinference.FixTypesVisitor.visit(FixTypesVisitor.java:99)
        */
    public static java.lang.String c(android.content.Context r20, java.lang.String r21, java.util.HashMap r22, java.lang.Object r23, int r24, java.util.concurrent.atomic.AtomicBoolean r25) {
        /*
            Method dump skipped, instruction units count: 1190
            To view this dump add '--comments-level debug' option
        */
        throw new UnsupportedOperationException("Method not decompiled: com.unicom.online.account.kernel.ai.c(android.content.Context, java.lang.String, java.util.HashMap, java.lang.Object, int, java.util.concurrent.atomic.AtomicBoolean):java.lang.String");
    }

    /* JADX WARN: Code duplicated, block: B:108:0x022f A[Catch: all -> 0x0168, Exception -> 0x0344, TRY_ENTER, TRY_LEAVE, TryCatch #0 {all -> 0x0168, blocks: (B:67:0x012b, B:68:0x0130, B:89:0x01df, B:93:0x0204, B:100:0x0217, B:108:0x022f, B:111:0x0239, B:117:0x0264, B:119:0x0275, B:120:0x0278, B:131:0x0292, B:104:0x0220, B:97:0x020d), top: B:196:0x0129 }] */
    /* JADX WARN: Code duplicated, block: B:111:0x0239 A[Catch: all -> 0x0168, Exception -> 0x0344, TRY_ENTER, TRY_LEAVE, TryCatch #0 {all -> 0x0168, blocks: (B:67:0x012b, B:68:0x0130, B:89:0x01df, B:93:0x0204, B:100:0x0217, B:108:0x022f, B:111:0x0239, B:117:0x0264, B:119:0x0275, B:120:0x0278, B:131:0x0292, B:104:0x0220, B:97:0x020d), top: B:196:0x0129 }] */
    /* JADX WARN: Code duplicated, block: B:117:0x0264 A[Catch: all -> 0x0168, Exception -> 0x0344, TRY_ENTER, TryCatch #0 {all -> 0x0168, blocks: (B:67:0x012b, B:68:0x0130, B:89:0x01df, B:93:0x0204, B:100:0x0217, B:108:0x022f, B:111:0x0239, B:117:0x0264, B:119:0x0275, B:120:0x0278, B:131:0x0292, B:104:0x0220, B:97:0x020d), top: B:196:0x0129 }] */
    /* JADX WARN: Code duplicated, block: B:119:0x0275 A[Catch: all -> 0x0168, Exception -> 0x0344, TryCatch #0 {all -> 0x0168, blocks: (B:67:0x012b, B:68:0x0130, B:89:0x01df, B:93:0x0204, B:100:0x0217, B:108:0x022f, B:111:0x0239, B:117:0x0264, B:119:0x0275, B:120:0x0278, B:131:0x0292, B:104:0x0220, B:97:0x020d), top: B:196:0x0129 }] */
    /* JADX WARN: Code duplicated, block: B:126:0x0289  */
    /* JADX WARN: Code duplicated, block: B:139:0x02d4 A[Catch: Exception -> 0x0344, all -> 0x0348, TryCatch #12 {all -> 0x0348, blocks: (B:85:0x0172, B:87:0x01ac, B:90:0x01e3, B:98:0x020f, B:105:0x0222, B:137:0x02c9, B:139:0x02d4, B:141:0x02e1, B:102:0x021a, B:95:0x0207), top: B:216:0x0172 }] */
    /* JADX WARN: Code duplicated, block: B:141:0x02e1 A[Catch: Exception -> 0x0344, all -> 0x0348, TRY_LEAVE, TryCatch #12 {all -> 0x0348, blocks: (B:85:0x0172, B:87:0x01ac, B:90:0x01e3, B:98:0x020f, B:105:0x0222, B:137:0x02c9, B:139:0x02d4, B:141:0x02e1, B:102:0x021a, B:95:0x0207), top: B:216:0x0172 }] */
    /* JADX WARN: Code duplicated, block: B:145:0x02ff A[Catch: Exception -> 0x0342, all -> 0x03b9, TryCatch #5 {all -> 0x03b9, blocks: (B:143:0x02fa, B:166:0x035e, B:145:0x02ff, B:147:0x0315), top: B:205:0x00f3 }] */
    /* JADX WARN: Code duplicated, block: B:147:0x0315 A[Catch: Exception -> 0x0342, all -> 0x03b9, TRY_LEAVE, TryCatch #5 {all -> 0x03b9, blocks: (B:143:0x02fa, B:166:0x035e, B:145:0x02ff, B:147:0x0315), top: B:205:0x00f3 }] */
    /* JADX WARN: Code duplicated, block: B:188:0x03d6  */
    /* JADX WARN: Code duplicated, block: B:197:0x03af A[EXC_TOP_SPLITTER, SYNTHETIC] */
    /* JADX WARN: Code duplicated, block: B:218:0x0151 A[EXC_TOP_SPLITTER, SYNTHETIC] */
    /* JADX WARN: Code duplicated, block: B:233:0x03bf A[EXC_TOP_SPLITTER, SYNTHETIC] */
    /* JADX WARN: Code duplicated, block: B:245:? A[SYNTHETIC] */
    /* JADX WARN: Code duplicated, block: B:57:0x00e0  */
    /* JADX WARN: Code duplicated, block: B:60:0x00f1  */
    /* JADX WARN: Code duplicated, block: B:63:0x011a A[Catch: all -> 0x0354, Exception -> 0x0358, TryCatch #27 {Exception -> 0x0358, all -> 0x0354, blocks: (B:61:0x00f3, B:63:0x011a, B:64:0x0123), top: B:205:0x00f3 }] */
    /* JADX WARN: Code duplicated, block: B:64:0x0123 A[Catch: all -> 0x0354, Exception -> 0x0358, TRY_LEAVE, TryCatch #27 {Exception -> 0x0358, all -> 0x0354, blocks: (B:61:0x00f3, B:63:0x011a, B:64:0x0123), top: B:205:0x00f3 }] */
    /* JADX WARN: Code duplicated, block: B:67:0x012b A[Catch: all -> 0x0168, Exception -> 0x034d, TRY_ENTER, TRY_LEAVE, TryCatch #0 {all -> 0x0168, blocks: (B:67:0x012b, B:68:0x0130, B:89:0x01df, B:93:0x0204, B:100:0x0217, B:108:0x022f, B:111:0x0239, B:117:0x0264, B:119:0x0275, B:120:0x0278, B:131:0x0292, B:104:0x0220, B:97:0x020d), top: B:196:0x0129 }] */
    /* JADX WARN: Code duplicated, block: B:84:0x016d  */
    /* JADX WARN: Code duplicated, block: B:89:0x01df A[Catch: all -> 0x0168, Exception -> 0x0344, TRY_ENTER, TRY_LEAVE, TryCatch #0 {all -> 0x0168, blocks: (B:67:0x012b, B:68:0x0130, B:89:0x01df, B:93:0x0204, B:100:0x0217, B:108:0x022f, B:111:0x0239, B:117:0x0264, B:119:0x0275, B:120:0x0278, B:131:0x0292, B:104:0x0220, B:97:0x020d), top: B:196:0x0129 }] */
    /* JADX WARN: Multi-variable type inference failed */
    /* JADX WARN: Type inference failed for: r12v4 */
    /* JADX WARN: Type inference failed for: r12v5, types: [java.lang.String] */
    /* JADX WARN: Type inference failed for: r12v6, types: [com.unicom.online.account.kernel.p] */
    /* JADX WARN: Type inference failed for: r12v7 */
    /* JADX WARN: Type inference failed for: r15v1 */
    /* JADX WARN: Type inference failed for: r15v2 */
    /* JADX WARN: Type inference failed for: r15v3 */
    /* JADX WARN: Type inference failed for: r15v4 */
    /* JADX WARN: Type inference failed for: r17v2, types: [java.lang.String] */
    /* JADX WARN: Type inference failed for: r17v3 */
    /* JADX WARN: Type inference failed for: r17v4 */
    /* JADX WARN: Type inference failed for: r17v5 */
    /* JADX WARN: Type inference failed for: r17v6 */
    /* JADX WARN: Type inference failed for: r17v7 */
    /* JADX WARN: Type inference failed for: r20v19 */
    /* JADX WARN: Type inference failed for: r20v2 */
    /* JADX WARN: Type inference failed for: r20v20 */
    /* JADX WARN: Type inference failed for: r20v21 */
    /* JADX WARN: Type inference failed for: r20v3 */
    /* JADX WARN: Type inference failed for: r20v4 */
    /* JADX WARN: Type inference failed for: r20v5 */
    /* JADX WARN: Type inference failed for: r20v6 */
    /* JADX WARN: Type inference failed for: r20v7 */
    /* JADX WARN: Type inference failed for: r2v10, types: [org.json.JSONObject] */
    /* JADX WARN: Type inference failed for: r2v19, types: [java.lang.StringBuilder] */
    /* JADX WARN: Type inference failed for: r2v23, types: [java.lang.StringBuilder] */
    /* JADX WARN: Type inference failed for: r2v7, types: [java.lang.StringBuilder] */
    /* JADX WARN: Type inference failed for: r3v4, types: [java.lang.String] */
    /* JADX WARN: Type inference failed for: r6v1, types: [java.lang.String] */
    public static String b(Context context, String str, HashMap map, Object obj, s sVar, int i, AtomicBoolean atomicBoolean) throws Throwable {
        String str2;
        String host;
        int i2;
        ?? r17;
        String str3;
        int i3;
        String str4;
        String str5;
        ?? r20;
        q qVar;
        Throwable th;
        ?? r15;
        ?? r12;
        bg bgVar;
        p pVarC;
        af afVarB;
        ?? r6;
        String strB;
        String str6;
        d dVarB;
        String str7;
        int i4;
        JSONObject jSONObject;
        t tVar;
        String str8 = "\n";
        String str9 = "";
        Thread.currentThread().getId();
        Thread.currentThread().getName();
        if (!Thread.currentThread().isInterrupted() && !atomicBoolean.get()) {
            int i5 = 443;
            try {
                URL url = new URL(str);
                host = url.getHost();
                try {
                    int port = url.getPort();
                    str2 = "exception:";
                    i2 = (port <= 0 || port > 65535) ? 443 : port;
                    try {
                        str9 = i2 + "";
                        while (true) {
                            try {
                                if (i3 >= ao.o.size()) {
                                    str5 = str4;
                                    tVar = null;
                                    break;
                                }
                                try {
                                    tVar = (t) ao.o.get(i3);
                                    if (i3 == i) {
                                        str5 = str4;
                                        try {
                                            if (tVar.b.equalsIgnoreCase(str3) && tVar.c.equalsIgnoreCase(str9)) {
                                                break;
                                            }
                                        } catch (Exception e) {
                                            e = e;
                                            e.getMessage();
                                            r20 = str5;
                                            if (str.contains("nisportal")) {
                                                u.b().b = 1;
                                            }
                                            str.substring(0, 30);
                                            if (!sVar.f) {
                                                qVar = sVar.b;
                                                try {
                                                    try {
                                                        bgVar = new bg();
                                                        bgVar.b = str.substring(0, str.indexOf("?"));
                                                        bgVar.c = System.currentTimeMillis();
                                                        as.b(str.substring(0, 30), 3);
                                                        if (obj != null) {
                                                            pVarC = qVar.c(str3, i2, (Network) obj);
                                                        } else {
                                                            pVarC = qVar.c(str3, i2, null);
                                                        }
                                                        r12 = pVarC;
                                                        try {
                                                            try {
                                                                if (r12 == 0) {
                                                                    JSONObject jSONObject2 = new JSONObject();
                                                                    try {
                                                                        as.b("exception:无法创建SSL连接\n", 3);
                                                                        jSONObject2.put(PluginConstants.KEY_ERROR_CODE, 410011);
                                                                        jSONObject2.put("msg", "https异常: 无法创建SSL连接");
                                                                        jSONObject2.put("data", "requestUrl:".concat(str));
                                                                        jSONObject2.put("callDepth", i);
                                                                        String string = jSONObject2.toString();
                                                                        if (r12 != 0) {
                                                                            try {
                                                                                qVar.getClass();
                                                                            } catch (Exception e2) {
                                                                                e2.getMessage();
                                                                            }
                                                                        }
                                                                        return string;
                                                                    } catch (Exception unused) {
                                                                        if (r12 == 0) {
                                                                            return null;
                                                                        }
                                                                        try {
                                                                            qVar.getClass();
                                                                            return null;
                                                                        } catch (Exception e3) {
                                                                            e3.getMessage();
                                                                            return null;
                                                                        }
                                                                    }
                                                                }
                                                                try {
                                                                    afVarB = ag.b(r12, str, map, str3);
                                                                    bgVar.d = System.currentTimeMillis();
                                                                    bgVar.e = 1L;
                                                                    as.b("cost:" + (bgVar.d - bgVar.c) + "ms\n", 3);
                                                                    r6 = r20;
                                                                    try {
                                                                        as.b("code:" + afVarB.b + r6, 3);
                                                                        as.b("body:" + afVarB.c + r6, 3);
                                                                        strB = b(str);
                                                                        if (bh.b(strB).booleanValue()) {
                                                                            strB = bp.c();
                                                                        }
                                                                        bgVar.b += "?seq=" + strB;
                                                                        str6 = u.b;
                                                                        if (str6 == null) {
                                                                            u.b = strB;
                                                                        } else {
                                                                            u.b = strB;
                                                                        }
                                                                        dVarB = u.b();
                                                                        str7 = dVarB.d;
                                                                        if (str7 == null) {
                                                                            dVarB.d = strB;
                                                                        } else {
                                                                            dVarB.d = strB;
                                                                        }
                                                                        u.b().b(bgVar);
                                                                        i4 = afVarB.b;
                                                                        if (i4 == 200) {
                                                                            if (TextUtils.isEmpty(afVarB.c)) {
                                                                                JSONObject jSONObject3 = new JSONObject();
                                                                                jSONObject3.put(PluginConstants.KEY_ERROR_CODE, 410012);
                                                                                jSONObject3.put("msg", "返回数据体为空");
                                                                                jSONObject3.put("seq", strB);
                                                                                jSONObject3.put("data", "requestUrl:".concat(str));
                                                                                jSONObject3.put("callDepth", i);
                                                                                String string2 = jSONObject3.toString();
                                                                                try {
                                                                                    qVar.getClass();
                                                                                } catch (Exception e4) {
                                                                                    e4.getMessage();
                                                                                }
                                                                                return string2;
                                                                            }
                                                                            jSONObject = new JSONObject(afVarB.c);
                                                                            if (TextUtils.isEmpty(jSONObject.optString("seq"))) {
                                                                                jSONObject.put("seq", strB);
                                                                            }
                                                                            jSONObject.put("callDepth", i);
                                                                            String string3 = jSONObject.toString();
                                                                            try {
                                                                                qVar.getClass();
                                                                            } catch (Exception e5) {
                                                                                e5.getMessage();
                                                                            }
                                                                            return string3;
                                                                        }
                                                                        if (i4 == 302) {
                                                                        }
                                                                        System.currentTimeMillis();
                                                                        try {
                                                                            if (!TextUtils.isEmpty(afVarB.d)) {
                                                                                qVar.getClass();
                                                                                if (afVarB.d.startsWith("https")) {
                                                                                    return b(context, afVarB.d, map, obj, sVar, i + 1, atomicBoolean);
                                                                                }
                                                                                return b(context, afVarB.d, map, obj, i + 1, atomicBoolean);
                                                                            }
                                                                            JSONObject jSONObject4 = new JSONObject();
                                                                            jSONObject4.put(PluginConstants.KEY_ERROR_CODE, 410013);
                                                                            jSONObject4.put("msg", "无跳转地址");
                                                                            jSONObject4.put("data", "requestUrl:".concat(str));
                                                                            jSONObject4.put("callDepth", i);
                                                                            String string4 = jSONObject4.toString();
                                                                            try {
                                                                                qVar.getClass();
                                                                            } catch (Exception e6) {
                                                                                e6.getMessage();
                                                                            }
                                                                            return string4;
                                                                        } catch (Exception e7) {
                                                                            e = e7;
                                                                            try {
                                                                                e.toString();
                                                                                as.b(str2 + e.getMessage() + r17, 3);
                                                                                ?? jSONObject5 = new JSONObject();
                                                                                jSONObject5.put(r12, 410011);
                                                                                jSONObject5.put("msg", "https异常: " + e.getMessage());
                                                                                jSONObject5.put("data", "requestUrl:".concat(str));
                                                                                jSONObject5.put("callDepth", i);
                                                                                String string5 = jSONObject5.toString();
                                                                                if (r20 != 0) {
                                                                                    try {
                                                                                        qVar.getClass();
                                                                                    } catch (Exception e8) {
                                                                                        e8.getMessage();
                                                                                    }
                                                                                }
                                                                                return string5;
                                                                            } catch (Exception unused2) {
                                                                                if (r20 == 0) {
                                                                                    return null;
                                                                                }
                                                                                try {
                                                                                    qVar.getClass();
                                                                                    return null;
                                                                                } catch (Exception e9) {
                                                                                    e9.getMessage();
                                                                                    return null;
                                                                                }
                                                                            }
                                                                        }
                                                                    } catch (Exception e10) {
                                                                        e = e10;
                                                                        r17 = r6;
                                                                        r20 = r12;
                                                                        r12 = PluginConstants.KEY_ERROR_CODE;
                                                                        e.toString();
                                                                        as.b(str2 + e.getMessage() + r17, 3);
                                                                        ?? jSONObject6 = new JSONObject();
                                                                        jSONObject6.put(r12, 410011);
                                                                        jSONObject6.put("msg", "https异常: " + e.getMessage());
                                                                        jSONObject6.put("data", "requestUrl:".concat(str));
                                                                        jSONObject6.put("callDepth", i);
                                                                        String string6 = jSONObject6.toString();
                                                                        if (r20 != 0) {
                                                                            qVar.getClass();
                                                                        }
                                                                        return string6;
                                                                    }
                                                                } catch (Throwable th2) {
                                                                    th = th2;
                                                                    r20 = r12;
                                                                    th = th;
                                                                    r15 = r20;
                                                                    if (r15 != 0) {
                                                                        try {
                                                                            qVar.getClass();
                                                                            throw th;
                                                                        } catch (Exception e11) {
                                                                            e11.getMessage();
                                                                            throw th;
                                                                        }
                                                                    }
                                                                    throw th;
                                                                }
                                                            } catch (Throwable th3) {
                                                                th = th3;
                                                                r15 = r12;
                                                                if (r15 != 0) {
                                                                    qVar.getClass();
                                                                    throw th;
                                                                }
                                                                throw th;
                                                            }
                                                        } catch (Exception e12) {
                                                            e = e12;
                                                            r17 = r20;
                                                        }
                                                    } catch (Throwable th4) {
                                                        th = th4;
                                                    }
                                                } catch (Exception e13) {
                                                    e = e13;
                                                    r12 = PluginConstants.KEY_ERROR_CODE;
                                                    r17 = r20;
                                                    r20 = 0;
                                                } catch (Throwable th5) {
                                                    th = th5;
                                                    r15 = 0;
                                                }
                                            } else {
                                                throw new IllegalStateException("ConnectionPoolManager已释放，不能再次使用");
                                            }
                                        }
                                    } else {
                                        str5 = str4;
                                    }
                                    i3++;
                                    str4 = str5;
                                } catch (Exception e14) {
                                    e = e14;
                                    str5 = str4;
                                }
                            } catch (Exception e15) {
                                e = e15;
                                str5 = str4;
                            }
                        }
                    } catch (MalformedURLException e16) {
                        e = e16;
                        i5 = i2;
                        as.b(e);
                        i2 = i5;
                    }
                } catch (MalformedURLException e17) {
                    e = e17;
                    str2 = "exception:";
                }
            } catch (MalformedURLException e18) {
                e = e18;
                str2 = "exception:";
                host = "";
            }
            r17 = "Https状态码错误";
            str3 = host;
            boolean z = ap.b;
            i3 = 0;
            str4 = str8;
            if (tVar == null) {
                try {
                    ao.b(i, context, str3, str9);
                    r20 = str5;
                } catch (Exception e19) {
                    e = e19;
                    e.getMessage();
                    r20 = str5;
                }
            } else {
                r20 = str5;
            }
            if (str.contains("nisportal")) {
                u.b().b = 1;
            }
            str.substring(0, 30);
            if (!sVar.f) {
                qVar = sVar.b;
                bgVar = new bg();
                bgVar.b = str.substring(0, str.indexOf("?"));
                bgVar.c = System.currentTimeMillis();
                as.b(str.substring(0, 30), 3);
                if (obj != null) {
                    pVarC = qVar.c(str3, i2, (Network) obj);
                } else {
                    pVarC = qVar.c(str3, i2, null);
                }
                r12 = pVarC;
                if (r12 == 0) {
                    JSONObject jSONObject7 = new JSONObject();
                    as.b("exception:无法创建SSL连接\n", 3);
                    jSONObject7.put(PluginConstants.KEY_ERROR_CODE, 410011);
                    jSONObject7.put("msg", "https异常: 无法创建SSL连接");
                    jSONObject7.put("data", "requestUrl:".concat(str));
                    jSONObject7.put("callDepth", i);
                    String string7 = jSONObject7.toString();
                    if (r12 != 0) {
                        qVar.getClass();
                    }
                    return string7;
                }
                afVarB = ag.b(r12, str, map, str3);
                bgVar.d = System.currentTimeMillis();
                bgVar.e = 1L;
                as.b("cost:" + (bgVar.d - bgVar.c) + "ms\n", 3);
                r6 = r20;
                as.b("code:" + afVarB.b + r6, 3);
                as.b("body:" + afVarB.c + r6, 3);
                strB = b(str);
                if (bh.b(strB).booleanValue()) {
                    strB = bp.c();
                }
                bgVar.b += "?seq=" + strB;
                str6 = u.b;
                if (str6 == null || str6.startsWith("seqEmpty")) {
                    u.b = strB;
                }
                dVarB = u.b();
                str7 = dVarB.d;
                if (str7 == null || str7.startsWith("seqEmpty")) {
                    dVarB.d = strB;
                }
                u.b().b(bgVar);
                i4 = afVarB.b;
                if (i4 == 200) {
                    if (TextUtils.isEmpty(afVarB.c)) {
                        JSONObject jSONObject8 = new JSONObject();
                        jSONObject8.put(PluginConstants.KEY_ERROR_CODE, 410012);
                        jSONObject8.put("msg", "返回数据体为空");
                        jSONObject8.put("seq", strB);
                        jSONObject8.put("data", "requestUrl:".concat(str));
                        jSONObject8.put("callDepth", i);
                        String string8 = jSONObject8.toString();
                        qVar.getClass();
                        return string8;
                    }
                    jSONObject = new JSONObject(afVarB.c);
                    if (TextUtils.isEmpty(jSONObject.optString("seq"))) {
                        jSONObject.put("seq", strB);
                    }
                    jSONObject.put("callDepth", i);
                    String string9 = jSONObject.toString();
                    qVar.getClass();
                    return string9;
                }
                if (i4 == 302 && i4 != 301) {
                    JSONObject jSONObject9 = new JSONObject();
                    jSONObject9.put(PluginConstants.KEY_ERROR_CODE, 410010);
                    jSONObject9.put("msg", ((String) r17) + afVarB.b);
                    jSONObject9.put("data", "requestUrl:".concat(str));
                    jSONObject9.put("callDepth", i);
                    String string10 = jSONObject9.toString();
                    try {
                        qVar.getClass();
                    } catch (Exception e20) {
                        e20.getMessage();
                    }
                    return string10;
                }
                System.currentTimeMillis();
                if (!TextUtils.isEmpty(afVarB.d)) {
                    qVar.getClass();
                    if (afVarB.d.startsWith("https")) {
                        return b(context, afVarB.d, map, obj, sVar, i + 1, atomicBoolean);
                    }
                    return b(context, afVarB.d, map, obj, i + 1, atomicBoolean);
                }
                JSONObject jSONObject10 = new JSONObject();
                jSONObject10.put(PluginConstants.KEY_ERROR_CODE, 410013);
                jSONObject10.put("msg", "无跳转地址");
                jSONObject10.put("data", "requestUrl:".concat(str));
                jSONObject10.put("callDepth", i);
                String string11 = jSONObject10.toString();
                qVar.getClass();
                return string11;
            }
            throw new IllegalStateException("ConnectionPoolManager已释放，不能再次使用");
        }
        JSONObject jSONObject11 = new JSONObject();
        try {
            jSONObject11.put(PluginConstants.KEY_ERROR_CODE, 410000);
            jSONObject11.put("msg", "请求超时");
            jSONObject11.put("data", "requestUrl:" + str);
            jSONObject11.put("callDepth", i);
            return jSONObject11.toString();
        } catch (Exception e21) {
            e21.getMessage();
            return null;
        }
    }

    /* JADX WARN: Code duplicated, block: B:86:0x0287  */
    /* JADX WARN: Not initialized variable reg: 13, insn: 0x0284: MOVE (r8 I:??[OBJECT, ARRAY]) = (r13 I:??[OBJECT, ARRAY]), block:B:84:0x0284 */
    public static String b(Context context, String str, HashMap map, Object obj, int i, AtomicBoolean atomicBoolean) throws Throwable {
        String host;
        HttpURLConnection httpURLConnection;
        HttpURLConnection httpURLConnection2;
        HttpURLConnection httpURLConnection3;
        System.currentTimeMillis();
        HttpURLConnection httpURLConnection4 = null;
        if (!Thread.currentThread().isInterrupted() && !atomicBoolean.get()) {
            try {
                host = new URL(str).getHost();
            } catch (MalformedURLException e) {
                as.b(e);
                host = str;
            }
            host.contains(bp.d());
            if (str.contains("nisportal")) {
                u.b().b = 1;
            }
            str.substring(0, 30);
            try {
                try {
                    URL url = new URL(str);
                    if (obj != null) {
                        httpURLConnection3 = (HttpURLConnection) ((Network) obj).openConnection(url);
                    } else {
                        httpURLConnection3 = (HttpURLConnection) url.openConnection();
                    }
                    httpURLConnection = httpURLConnection3;
                    try {
                        httpURLConnection.setDoInput(true);
                        httpURLConnection.setDoOutput(false);
                        httpURLConnection.setUseCaches(false);
                        httpURLConnection.setInstanceFollowRedirects(false);
                        httpURLConnection.setReadTimeout(10000);
                        httpURLConnection.setConnectTimeout(10000);
                        httpURLConnection.setRequestMethod("GET");
                        boolean z = ap.d;
                        httpURLConnection.setInstanceFollowRedirects(z);
                        HttpURLConnection.setFollowRedirects(z);
                        if (map != null) {
                            for (String str2 : map.keySet()) {
                                httpURLConnection.setRequestProperty(str2, (String) map.get(str2));
                            }
                        }
                        httpURLConnection.addRequestProperty("Connection", "close");
                        bg bgVar = new bg();
                        bgVar.b = str.substring(0, str.indexOf("?"));
                        bgVar.c = System.currentTimeMillis();
                        httpURLConnection.connect();
                        bgVar.d = System.currentTimeMillis();
                        bgVar.e = 1L;
                        System.currentTimeMillis();
                        System.currentTimeMillis();
                        int responseCode = httpURLConnection.getResponseCode();
                        System.currentTimeMillis();
                        String strB = b(str);
                        if (bh.b(strB).booleanValue()) {
                            strB = bp.c();
                        }
                        bgVar.b += "?seq=" + strB;
                        String str3 = u.b;
                        if (str3 == null || str3.startsWith("seqEmpty")) {
                            u.b = strB;
                        }
                        d dVarB = u.b();
                        String str4 = dVarB.d;
                        if (str4 == null || str4.startsWith("seqEmpty")) {
                            dVarB.d = strB;
                        }
                        u.b().b(bgVar);
                        if (responseCode == 200) {
                            InputStream inputStream = httpURLConnection.getInputStream();
                            String strB2 = b(inputStream);
                            httpURLConnection.getInputStream().close();
                            httpURLConnection.disconnect();
                            inputStream.close();
                            if (!TextUtils.isEmpty(strB2)) {
                                httpURLConnection.disconnect();
                                return strB2;
                            }
                            JSONObject jSONObject = new JSONObject();
                            jSONObject.put(PluginConstants.KEY_ERROR_CODE, 410012);
                            jSONObject.put("msg", "返回数据体为空");
                            jSONObject.put("data", "requestUrl:" + str);
                            String string = jSONObject.toString();
                            httpURLConnection.disconnect();
                            return string;
                        }
                        if (responseCode == 302) {
                            String headerField = httpURLConnection.getHeaderField("Location");
                            System.currentTimeMillis();
                            if (!TextUtils.isEmpty(headerField)) {
                                if (headerField.startsWith("https")) {
                                    String strC = c(context, headerField, null, obj, i + 1, atomicBoolean);
                                    httpURLConnection.disconnect();
                                    return strC;
                                }
                                System.currentTimeMillis();
                                String strB3 = b(context, headerField, null, obj, i + 1, atomicBoolean);
                                httpURLConnection.disconnect();
                                return strB3;
                            }
                            JSONObject jSONObject2 = new JSONObject();
                            jSONObject2.put(PluginConstants.KEY_ERROR_CODE, 410013);
                            jSONObject2.put("msg", "无跳转地址");
                            jSONObject2.put("data", "requestUrl:" + str);
                            String string2 = jSONObject2.toString();
                            httpURLConnection.disconnect();
                            return string2;
                        }
                        JSONObject jSONObject3 = new JSONObject();
                        jSONObject3.put(PluginConstants.KEY_ERROR_CODE, 410010);
                        jSONObject3.put("msg", "Https状态码错误" + responseCode);
                        jSONObject3.put("data", "requestUrl:" + str);
                        String string3 = jSONObject3.toString();
                        httpURLConnection.disconnect();
                        return string3;
                    } catch (Exception e2) {
                        e = e2;
                        as.b(e);
                        try {
                            JSONObject jSONObject4 = new JSONObject();
                            jSONObject4.put(PluginConstants.KEY_ERROR_CODE, 410024);
                            jSONObject4.put("msg", "http异常" + e.getMessage());
                            jSONObject4.put("data", "requestUrl:" + str);
                            String string4 = jSONObject4.toString();
                            if (httpURLConnection != null) {
                                httpURLConnection.disconnect();
                            }
                            return string4;
                        } catch (Exception unused) {
                            if (httpURLConnection != null) {
                                httpURLConnection.disconnect();
                            }
                            return null;
                        }
                    }
                } catch (Throwable th) {
                    th = th;
                    httpURLConnection4 = httpURLConnection2;
                    if (httpURLConnection4 != null) {
                        httpURLConnection4.disconnect();
                    }
                    throw th;
                }
            } catch (Exception e3) {
                e = e3;
                httpURLConnection = null;
            } catch (Throwable th2) {
                th = th2;
                if (httpURLConnection4 != null) {
                    httpURLConnection4.disconnect();
                }
                throw th;
            }
        } else {
            JSONObject jSONObject5 = new JSONObject();
            try {
                jSONObject5.put(PluginConstants.KEY_ERROR_CODE, 410000);
                jSONObject5.put("msg", "请求超时");
                jSONObject5.put("data", "requestUrl:" + str);
                jSONObject5.put("callDepth", i);
                return jSONObject5.toString();
            } catch (Exception e4) {
                e4.getMessage();
                return null;
            }
        }
    }

    public static String b(String str, String str2) {
        String strB = "";
        OutputStream outputStream = null;
        try {
            try {
                URL url = new URL(str);
                HttpURLConnection httpURLConnection = (HttpURLConnection) url.openConnection();
                String protocol = url.getProtocol();
                if (bh.c(protocol).booleanValue()) {
                    "https".equals(protocol.toLowerCase(Locale.getDefault()));
                }
                httpURLConnection.setConnectTimeout(50000);
                httpURLConnection.setReadTimeout(50000);
                httpURLConnection.setDoOutput(true);
                httpURLConnection.setDoInput(true);
                httpURLConnection.setUseCaches(false);
                httpURLConnection.setRequestMethod("POST");
                httpURLConnection.setRequestProperty("user-agent", "Mozilla/5.0 (Linux; U; Android %s) AppleWebKit/533.1 (KHTML, like Gecko) Version/4.0 %sSafari/533.1");
                httpURLConnection.setRequestProperty("Charset", "UTF-8");
                httpURLConnection.setRequestProperty("connection", "keep-alive");
                httpURLConnection.setRequestProperty("api-protocol", "1.1");
                httpURLConnection.connect();
                outputStream = httpURLConnection.getOutputStream();
                outputStream.write(str2.getBytes("utf-8"));
                outputStream.flush();
                outputStream.close();
                if (httpURLConnection.getResponseCode() == 200) {
                    InputStream inputStream = httpURLConnection.getInputStream();
                    strB = b(inputStream);
                    httpURLConnection.disconnect();
                    inputStream.close();
                }
                try {
                    outputStream.close();
                } catch (IOException e) {
                    as.b(e);
                }
                return strB;
            } catch (Throwable th) {
                if (outputStream != null) {
                    try {
                        outputStream.close();
                    } catch (IOException e2) {
                        as.b(e2);
                    }
                }
                throw th;
            }
        } catch (Exception e3) {
            as.b(e3);
            if (outputStream != null) {
                try {
                    outputStream.close();
                } catch (IOException e4) {
                    as.b(e4);
                }
            }
            return strB;
        }
    }

    /* JADX WARN: Code duplicated, block: B:29:0x0043 A[Catch: Exception -> 0x003f, TRY_LEAVE, TryCatch #0 {Exception -> 0x003f, blocks: (B:25:0x003b, B:29:0x0043), top: B:42:0x003b }] */
    /* JADX WARN: Code duplicated, block: B:38:0x0055 A[Catch: Exception -> 0x0051, TRY_LEAVE, TryCatch #5 {Exception -> 0x0051, blocks: (B:34:0x004d, B:38:0x0055), top: B:49:0x004d }] */
    public static String b(InputStream inputStream) throws Throwable {
        ByteArrayOutputStream byteArrayOutputStream;
        Throwable th;
        try {
            byteArrayOutputStream = new ByteArrayOutputStream();
            try {
                try {
                    byte[] bArr = new byte[1024];
                    while (true) {
                        int i = inputStream.read(bArr);
                        if (i == -1) {
                            break;
                        }
                        byteArrayOutputStream.write(bArr, 0, i);
                        th = th;
                        if (byteArrayOutputStream != null) {
                            try {
                                byteArrayOutputStream.close();
                                if (inputStream != null) {
                                    inputStream.close();
                                }
                            } catch (Exception e) {
                                as.b(e);
                            }
                        } else if (inputStream != null) {
                            inputStream.close();
                        }
                        throw th;
                    }
                    String str = new String(byteArrayOutputStream.toByteArray());
                    try {
                        byteArrayOutputStream.close();
                        inputStream.close();
                    } catch (Exception e2) {
                        as.b(e2);
                    }
                    return str;
                } catch (Exception e3) {
                    e = e3;
                    as.b(e);
                    if (byteArrayOutputStream != null) {
                        try {
                            byteArrayOutputStream.close();
                            if (inputStream != null) {
                                inputStream.close();
                            }
                        } catch (Exception e4) {
                            as.b(e4);
                            return null;
                        }
                    } else if (inputStream != null) {
                        inputStream.close();
                    }
                    return null;
                }
            } catch (Throwable th2) {
                th = th2;
            }
        } catch (Exception e5) {
            e = e5;
            byteArrayOutputStream = null;
        } catch (Throwable th3) {
            byteArrayOutputStream = null;
            th = th3;
        }
    }

    public static String b(String str) {
        String strC = bp.c();
        if (str == null || !str.contains("ret_url")) {
            return strC;
        }
        try {
            String queryParameter = Uri.parse(new String(Base64.decode(Uri.parse(str).getQueryParameter("ret_url"), 0))).getQueryParameter("seq");
            return !TextUtils.isEmpty(queryParameter) ? queryParameter : strC;
        } catch (Exception e) {
            e.getMessage();
            return strC;
        }
    }
}
