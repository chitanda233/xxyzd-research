package com.chuanglan.shanyan_sdk;

import com.baidu.mobads.sdk.internal.bz;
import java.io.ByteArrayOutputStream;
import java.io.IOException;
import java.security.MessageDigest;
import java.security.NoSuchAlgorithmException;
import java.util.List;
import java.util.Map;
import java.util.Objects;
import java.util.TreeSet;
import java.util.zip.GZIPOutputStream;
import javax.crypto.Cipher;
import javax.crypto.Mac;
import javax.crypto.spec.IvParameterSpec;
import javax.crypto.spec.SecretKeySpec;
import kotlin.UByte;
import org.json.JSONArray;

/* JADX INFO: renamed from: com.chuanglan.shanyan_sdk.b, reason: case insensitive filesystem */
/* JADX INFO: loaded from: classes2.dex */
public abstract class AbstractC0596b {
    public static String a(Map map, String str) {
        TreeSet<String> treeSet = new TreeSet(map.keySet());
        StringBuilder sb = new StringBuilder();
        for (String str2 : treeSet) {
            if (!"i7".equals(str2)) {
                sb.append(str2).append(map.get(str2));
            }
        }
        Q.c("ProcessShanYanLogger", "getSign stringSet", sb.toString());
        return a(sb.toString(), str);
    }

    public static String b(String str) {
        if (AbstractC0600f.a(str)) {
            return "";
        }
        try {
            String str2 = "";
            for (byte b : MessageDigest.getInstance(bz.f456a).digest(str.getBytes())) {
                String hexString = Integer.toHexString(b & UByte.MAX_VALUE);
                if (hexString.length() == 1) {
                    hexString = "0" + hexString;
                }
                str2 = str2 + hexString;
            }
            return str2;
        } catch (NoSuchAlgorithmException e) {
            e.printStackTrace();
            return "";
        }
    }

    private static String a(String str, String str2) {
        try {
            SecretKeySpec secretKeySpec = new SecretKeySpec(str2.getBytes("UTF-8"), "HmacSHA1");
            Mac mac = Mac.getInstance("HmacSHA1");
            mac.init(secretKeySpec);
            return AbstractC0605k.a(mac.doFinal(str.getBytes("UTF-8")));
        } catch (Exception e) {
            e.printStackTrace();
            return null;
        }
    }

    /* JADX WARN: Code duplicated, block: B:59:0x006f A[EXC_TOP_SPLITTER, SYNTHETIC] */
    /* JADX WARN: Type inference failed for: r0v0, types: [boolean] */
    /* JADX WARN: Type inference failed for: r0v1 */
    /* JADX WARN: Type inference failed for: r0v10 */
    /* JADX WARN: Type inference failed for: r0v11 */
    /* JADX WARN: Type inference failed for: r0v12 */
    /* JADX WARN: Type inference failed for: r0v2, types: [java.io.ByteArrayOutputStream, java.io.OutputStream] */
    /* JADX WARN: Type inference failed for: r0v9 */
    /* JADX WARN: Unsupported multi-entry loop pattern (BACK_EDGE: B:25:0x0035 -> B:61:0x0038). Please report as a decompilation issue!!! */
    public static byte[] a(String str) throws Throwable {
        ByteArrayOutputStream byteArrayOutputStream;
        GZIPOutputStream gZIPOutputStream;
        ?? A = AbstractC0600f.a(str);
        GZIPOutputStream gZIPOutputStream2 = null;
        try {
            if (A != 0) {
                return null;
            }
            try {
                try {
                    byteArrayOutputStream = new ByteArrayOutputStream();
                    try {
                        gZIPOutputStream = new GZIPOutputStream(byteArrayOutputStream);
                        try {
                            gZIPOutputStream.write(str.getBytes("UTF-8"));
                            gZIPOutputStream.close();
                            A = byteArrayOutputStream;
                        } catch (Exception e) {
                            e = e;
                            try {
                                e.printStackTrace();
                                A = byteArrayOutputStream;
                                if (gZIPOutputStream != null) {
                                    gZIPOutputStream.close();
                                    A = byteArrayOutputStream;
                                }
                            } catch (Throwable th) {
                                th = th;
                                gZIPOutputStream2 = gZIPOutputStream;
                                gZIPOutputStream = gZIPOutputStream2;
                                if (gZIPOutputStream != null) {
                                    try {
                                        gZIPOutputStream.close();
                                    } catch (IOException e2) {
                                        e2.printStackTrace();
                                    }
                                }
                                throw th;
                            }
                        } catch (Throwable th2) {
                            th = th2;
                            if (gZIPOutputStream != null) {
                                gZIPOutputStream.close();
                            }
                            throw th;
                        }
                    } catch (Exception e3) {
                        e = e3;
                        gZIPOutputStream = null;
                    }
                } catch (Throwable th3) {
                    th = th3;
                    gZIPOutputStream = gZIPOutputStream2;
                    if (gZIPOutputStream != null) {
                        gZIPOutputStream.close();
                    }
                    throw th;
                }
            } catch (Exception e4) {
                e = e4;
                byteArrayOutputStream = null;
                gZIPOutputStream = null;
            }
            try {
                try {
                    byte[] byteArray = A.toByteArray();
                    try {
                        A.flush();
                        A.close();
                    } catch (IOException e5) {
                        e5.printStackTrace();
                    }
                    return byteArray;
                } catch (Exception e6) {
                    e6.printStackTrace();
                    if (A != 0) {
                        try {
                            A.flush();
                            A.close();
                        } catch (IOException e7) {
                            e7.printStackTrace();
                        }
                    }
                    return null;
                }
            } catch (Throwable th4) {
                if (A != 0) {
                    try {
                        A.flush();
                        A.close();
                    } catch (IOException e8) {
                        e8.printStackTrace();
                    }
                }
                throw th4;
            }
        } catch (IOException e9) {
            e9.printStackTrace();
            A = A;
        }
    }

    public static JSONArray b(List list) {
        JSONArray jSONArray = new JSONArray();
        for (int i = 0; i < list.size(); i++) {
            C0620z c0620z = (C0620z) list.get(i);
            JSONArray jSONArray2 = new JSONArray();
            try {
                jSONArray2.put(c0620z.f2037a);
                jSONArray2.put(c0620z.b);
                jSONArray2.put(c0620z.c);
                jSONArray2.put(c0620z.d);
                jSONArray2.put(c0620z.e);
                jSONArray.put(jSONArray2);
            } catch (Exception e) {
                e.printStackTrace();
            }
        }
        return jSONArray;
    }

    public static JSONArray a(List list) {
        JSONArray jSONArray = new JSONArray();
        C0619y c0619y = (C0619y) list.get(0);
        for (int i = 0; i < list.size(); i++) {
            C0619y c0619y2 = (C0619y) list.get(i);
            JSONArray jSONArray2 = new JSONArray();
            if (i == 0) {
                try {
                    jSONArray2.put(c0619y2.f2036a);
                    jSONArray2.put(c0619y2.b);
                    jSONArray2.put(c0619y2.c);
                    jSONArray2.put(c0619y2.d);
                    jSONArray2.put(c0619y2.e);
                    jSONArray2.put(c0619y2.f);
                    jSONArray2.put(c0619y2.g);
                    jSONArray2.put(c0619y2.h);
                    jSONArray2.put(c0619y2.i);
                    jSONArray2.put(c0619y2.j);
                    jSONArray2.put(c0619y2.k);
                    jSONArray2.put(c0619y2.l);
                    jSONArray2.put(c0619y2.m);
                    jSONArray2.put(c0619y2.n);
                    jSONArray2.put(c0619y2.o);
                    jSONArray2.put(c0619y2.p);
                    jSONArray2.put(c0619y2.q);
                    jSONArray2.put(c0619y2.r);
                    jSONArray2.put(c0619y2.s);
                    jSONArray2.put(c0619y2.t);
                    jSONArray2.put(c0619y2.u);
                    jSONArray2.put(c0619y2.v);
                    jSONArray2.put(c0619y2.w);
                    jSONArray2.put(c0619y2.x);
                } catch (Exception e) {
                    e.printStackTrace();
                }
            } else {
                if (Objects.equals(c0619y.f2036a, c0619y2.f2036a)) {
                    jSONArray2.put("@");
                } else {
                    jSONArray2.put(c0619y2.f2036a);
                }
                if (Objects.equals(c0619y.b, c0619y2.b)) {
                    jSONArray2.put("@");
                } else {
                    jSONArray2.put(c0619y2.b);
                }
                int i2 = c0619y.c;
                int i3 = c0619y2.c;
                if (i2 == i3) {
                    jSONArray2.put("@");
                } else {
                    jSONArray2.put(i3);
                }
                jSONArray2.put("@");
                jSONArray2.put("@");
                jSONArray2.put("@");
                jSONArray2.put("@");
                if (Objects.equals(c0619y.h, c0619y2.h)) {
                    jSONArray2.put("@");
                } else {
                    jSONArray2.put(c0619y2.h);
                }
                if (Objects.equals(c0619y.i, c0619y2.i)) {
                    jSONArray2.put("@");
                } else {
                    jSONArray2.put(c0619y2.i);
                }
                if (Objects.equals(c0619y.j, c0619y2.j)) {
                    jSONArray2.put("@");
                } else {
                    jSONArray2.put(c0619y2.j);
                }
                if (Objects.equals(c0619y.k, c0619y2.k)) {
                    jSONArray2.put("@");
                } else {
                    jSONArray2.put(c0619y2.k);
                }
                if (Objects.equals(c0619y.l, c0619y2.l)) {
                    jSONArray2.put("@");
                } else {
                    jSONArray2.put(c0619y2.l);
                }
                int i4 = c0619y.m;
                int i5 = c0619y2.m;
                if (i4 == i5) {
                    jSONArray2.put("@");
                } else {
                    jSONArray2.put(i5);
                }
                int i6 = c0619y.n;
                int i7 = c0619y2.n;
                if (i6 == i7) {
                    jSONArray2.put("@");
                } else {
                    jSONArray2.put(i7);
                }
                jSONArray2.put(c0619y2.o);
                jSONArray2.put(c0619y2.p);
                jSONArray2.put(c0619y2.q);
                int i8 = c0619y.r;
                int i9 = c0619y2.r;
                if (i8 == i9) {
                    jSONArray2.put("@");
                } else {
                    jSONArray2.put(i9);
                }
                int i10 = c0619y.s;
                int i11 = c0619y2.s;
                if (i10 == i11) {
                    jSONArray2.put("@");
                } else {
                    jSONArray2.put(i11);
                }
                if (Objects.equals(c0619y.t, c0619y2.t)) {
                    jSONArray2.put("@");
                } else {
                    jSONArray2.put(c0619y2.t);
                }
                int i12 = c0619y.u;
                int i13 = c0619y2.u;
                if (i12 == i13) {
                    jSONArray2.put("@");
                } else {
                    jSONArray2.put(i13);
                }
                if (Objects.equals(c0619y.v, c0619y2.v)) {
                    jSONArray2.put("@");
                } else {
                    jSONArray2.put(c0619y2.v);
                }
                int i14 = c0619y.w;
                int i15 = c0619y2.w;
                if (i14 == i15) {
                    jSONArray2.put("@");
                } else {
                    jSONArray2.put(i15);
                }
                if (Objects.equals(c0619y.x, c0619y2.x)) {
                    jSONArray2.put("@");
                } else {
                    jSONArray2.put(c0619y2.x);
                }
            }
            jSONArray.put(jSONArray2);
        }
        return jSONArray;
    }

    public static byte[] a(byte[] bArr, String str, String str2) {
        try {
            Cipher cipher = Cipher.getInstance("AES/CBC/PKCS5Padding");
            cipher.init(1, new SecretKeySpec(str.getBytes(), "AES"), new IvParameterSpec(str2.getBytes()));
            return cipher.doFinal(bArr);
        } catch (Exception e) {
            e.printStackTrace();
            return null;
        }
    }
}
