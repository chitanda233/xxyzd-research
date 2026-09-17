package com.gorilla.base.service;

import android.content.Context;
import com.baidu.mobads.sdk.internal.bz;
import java.security.MessageDigest;
import java.util.Locale;
import kotlin.UByte;

/* JADX INFO: loaded from: classes3.dex */
public class SignatureGenerator {
    public static String getSignatureMD5(Context context) {
        try {
            byte[] bArrDigest = MessageDigest.getInstance(bz.f456a).digest(context.getPackageManager().getPackageInfo(context.getPackageName(), 64).signatures[0].toByteArray());
            StringBuilder sb = new StringBuilder();
            for (byte b : bArrDigest) {
                String lowerCase = Integer.toHexString(b & UByte.MAX_VALUE).toLowerCase(Locale.US);
                if (lowerCase.length() == 1) {
                    sb.append("0");
                }
                sb.append(lowerCase);
            }
            return sb.toString();
        } catch (Exception e) {
            e.printStackTrace();
            return null;
        }
    }

    public static String getSignatureSHA1(Context context) {
        try {
            byte[] bArrDigest = MessageDigest.getInstance("SHA1").digest(context.getPackageManager().getPackageInfo(context.getPackageName(), 64).signatures[0].toByteArray());
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < bArrDigest.length; i++) {
                String upperCase = Integer.toHexString(bArrDigest[i] & UByte.MAX_VALUE).toUpperCase(Locale.US);
                if (upperCase.length() == 1) {
                    sb.append("0");
                }
                sb.append(upperCase);
                if (i < bArrDigest.length - 1) {
                    sb.append(":");
                }
            }
            return sb.toString();
        } catch (Exception e) {
            e.printStackTrace();
            return null;
        }
    }

    public static String getSignatureSHA256(Context context) {
        try {
            byte[] bArrDigest = MessageDigest.getInstance("SHA256").digest(context.getPackageManager().getPackageInfo(context.getPackageName(), 64).signatures[0].toByteArray());
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < bArrDigest.length; i++) {
                String upperCase = Integer.toHexString(bArrDigest[i] & UByte.MAX_VALUE).toUpperCase(Locale.US);
                if (upperCase.length() == 1) {
                    sb.append("0");
                }
                sb.append(upperCase);
                if (i < bArrDigest.length - 1) {
                    sb.append(":");
                }
            }
            return sb.toString();
        } catch (Exception e) {
            e.printStackTrace();
            return null;
        }
    }
}
