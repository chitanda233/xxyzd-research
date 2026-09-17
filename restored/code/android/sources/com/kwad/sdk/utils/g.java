package com.kwad.sdk.utils;

import android.content.Context;
import android.content.pm.PackageInfo;
import android.content.pm.Signature;
import android.text.TextUtils;
import java.security.MessageDigest;
import java.util.ArrayList;
import java.util.HashMap;
import kotlin.UByte;

/* JADX INFO: loaded from: classes3.dex */
public final class g {
    private static HashMap<String, ArrayList<String>> boe = new HashMap<>();
    private static String bof;

    private static ArrayList<String> Q(Context context, String str) {
        String packageName;
        if (context == null || (packageName = context.getPackageName()) == null) {
            return null;
        }
        if (boe.get(str) != null) {
            return boe.get(str);
        }
        ArrayList<String> arrayList = new ArrayList<>();
        try {
            for (Signature signature : getSignatures(context, packageName)) {
                String strA = "error!";
                if (com.baidu.mobads.sdk.internal.bz.f456a.equals(str)) {
                    strA = a(signature, com.baidu.mobads.sdk.internal.bz.f456a);
                } else if ("SHA1".equals(str)) {
                    strA = a(signature, "SHA1");
                } else if ("SHA256".equals(str)) {
                    strA = a(signature, "SHA256");
                }
                arrayList.add(strA);
            }
        } catch (Exception e) {
            com.kwad.sdk.core.d.c.e("AppSigningUtil", "签名信息列表获取失败 " + e.getMessage());
        }
        boe.put(str, arrayList);
        return arrayList;
    }

    public static String cM(Context context) {
        if (!TextUtils.isEmpty(bof)) {
            return bof;
        }
        ArrayList<String> arrayListQ = Q(context, "SHA1");
        if (arrayListQ != null && arrayListQ.size() != 0) {
            bof = arrayListQ.get(0);
        }
        return bof;
    }

    private static Signature[] getSignatures(Context context, String str) {
        try {
            PackageInfo packageInfo = aa.getPackageInfo(context, str, 64);
            if (packageInfo == null) {
                return null;
            }
            return packageInfo.signatures;
        } catch (Exception e) {
            com.kwad.sdk.core.d.c.e("AppSigningUtil", e.getMessage());
            return null;
        }
    }

    private static String a(Signature signature, String str) {
        byte[] byteArray = signature.toByteArray();
        try {
            MessageDigest messageDigest = MessageDigest.getInstance(str);
            if (messageDigest == null) {
                return "error!";
            }
            byte[] bArrDigest = messageDigest.digest(byteArray);
            StringBuilder sb = new StringBuilder();
            for (byte b : bArrDigest) {
                sb.append(Integer.toHexString((b & UByte.MAX_VALUE) | 256).substring(1, 3).toUpperCase());
                sb.append(":");
            }
            return sb.substring(0, sb.length() - 1);
        } catch (Exception e) {
            com.kwad.sdk.core.d.c.e("AppSigningUtil", e.getMessage());
            return "error!";
        }
    }
}
