package com.unicom.online.account.kernel;

import android.content.Context;
import android.content.SharedPreferences;
import android.util.Log;
import com.alipay.sdk.m.w.a;
import java.net.URLEncoder;
import java.security.KeyFactory;
import java.security.PublicKey;
import java.security.spec.X509EncodedKeySpec;
import java.util.HashMap;
import java.util.Map;
import java.util.TreeMap;
import javax.crypto.Cipher;

/* JADX INFO: loaded from: classes4.dex */
public abstract class an {
    public static final ak b = new ak();

    public static String b(TreeMap treeMap) throws Exception {
        try {
            StringBuilder sb = new StringBuilder();
            for (Map.Entry entry : treeMap.entrySet()) {
                String str = (String) entry.getKey();
                Object value = entry.getValue();
                if (value != null && bh.c(str).booleanValue()) {
                    sb.append(str).append("=").append(URLEncoder.encode(value.toString(), "UTF-8")).append(a.p);
                }
            }
            sb.deleteCharAt(sb.length() - 1);
            return sb.toString();
        } catch (Exception e) {
            Log.e("TAG", "getURLParames: " + e.getMessage());
            throw new Exception("http请求参数出错");
        }
    }

    public static void c(final Context context) {
        b.newThread(new Runnable() { // from class: com.unicom.online.account.kernel.an$$ExternalSyntheticLambda1
            @Override // java.lang.Runnable
            public final void run() {
                an.b(context);
            }
        }).start();
    }

    public static String b(String str) {
        String strC;
        try {
            String strC2 = ao.c();
            try {
                strC = b.c(str, strC2.substring(0, 16), strC2.substring(16, 32));
            } catch (Exception e) {
                as.b(e);
                strC = null;
            }
            PublicKey publicKeyGeneratePublic = KeyFactory.getInstance(com.alipay.sdk.m.p.d.f334a).generatePublic(new X509EncodedKeySpec(aq.b("MIGfMA0GCSqGSIb3DQEBAQUAA4GNADCBiQKBgQCqlsahFVMRr61qP/zUqXJlhwhEAR6ynO9ldpawnABDwDiHDymSzsSyyHKE2mS3178d0gGJ5v0TnpNh3+IiOQknpRUvAvXeA9P8DkCNBZBSwCEHo74xQ1+TLMk7f0Qn45GfMipLO0ryYCR4Xg4zE8TubqJ2oyy9pi/QoBdtjx+vJwIDAQAB")));
            Cipher cipher = Cipher.getInstance("RSA/ECB/PKCS1Padding");
            cipher.init(1, publicKeyGeneratePublic);
            String strB = aq.b(cipher.doFinal(strC2.getBytes()));
            String strB2 = au.b(ao.j + "?params=" + strC + "&paramsKey=" + strB);
            TreeMap treeMap = new TreeMap();
            HashMap map = new HashMap(16);
            treeMap.put("params", strC);
            treeMap.put("paramsKey", strB);
            treeMap.put("sign", strB2);
            map.put("sign", strB2);
            map.put("api-protocol", "1.1");
            try {
                return b(treeMap);
            } catch (Exception e2) {
                as.b(e2);
                return "";
            }
        } catch (Exception e3) {
            as.b(e3);
            Log.d("TAG", "run: " + e3.toString());
            return null;
        }
    }

    public static void b() {
        d dVar = u.c;
        dVar.b = 0;
        dVar.c = 0L;
        bg bgVar = dVar.f;
        if (bgVar != null) {
            bgVar.b = "";
            bgVar.c = 0L;
            bgVar.d = 0L;
            bgVar.e = 0L;
        }
        bg bgVar2 = dVar.g;
        if (bgVar2 != null) {
            bgVar2.b = "";
            bgVar2.c = 0L;
            bgVar2.d = 0L;
            bgVar2.e = 0L;
        }
        bg bgVar3 = dVar.h;
        if (bgVar3 != null) {
            bgVar3.b = "";
            bgVar3.c = 0L;
            bgVar3.d = 0L;
            bgVar3.e = 0L;
        }
        bg bgVar4 = dVar.i;
        if (bgVar4 != null) {
            bgVar4.b = "";
            bgVar4.c = 0L;
            bgVar4.d = 0L;
            bgVar4.e = 0L;
        }
    }

    public static void b(Context context) {
        String string = "";
        try {
            if (at.c <= 0) {
                string = null;
            } else {
                String str = "at" + ((at.b + at.c) - 1);
                try {
                    try {
                        string = context.getSharedPreferences("cuAuthCacheName", 0).getString("OAlog" + str + str, "");
                    } catch (Exception e) {
                        e.getMessage();
                    }
                } catch (Exception unused) {
                    at.c = 0;
                    string = null;
                }
            }
            if (string == null) {
                return;
            }
            String strB = ai.b("https://" + ao.g + ao.j, string);
            if (strB.contains("\"code\":0")) {
                "缓存日志上传成功: ".concat(strB);
                String str2 = "at" + ((at.b + at.c) - 1);
                SharedPreferences.Editor editorEdit = context.getSharedPreferences("cuAuthCacheName", 0).edit();
                editorEdit.remove("OAlog" + str2 + str2);
                editorEdit.commit();
                int i = at.c;
                if (i >= 1) {
                    at.c = i - 1;
                } else {
                    at.c = 0;
                }
            }
        } catch (Exception e2) {
            as.b(e2);
        }
    }

    public static void b(String str, Context context) {
        try {
            try {
                String strB = b(str);
                if (bh.c(strB).booleanValue()) {
                    if (ai.b("https://" + ao.g + ao.j, strB).contains("\"code\":0")) {
                        c(context);
                    } else {
                        at.b(context, strB);
                    }
                }
            } catch (Exception e) {
                as.b(e);
            }
        } finally {
            b();
        }
    }

    public static void b(final Context context, final String str) {
        if (ap.b) {
            b.newThread(new Runnable() { // from class: com.unicom.online.account.kernel.an$$ExternalSyntheticLambda0
                @Override // java.lang.Runnable
                public final void run() {
                    an.b(str, context);
                }
            }).start();
        }
    }
}
