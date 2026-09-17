package com.chuanglan.shanyan_sdk;

import android.content.Context;
import android.content.pm.Signature;
import com.baidu.mobads.sdk.internal.bz;
import java.security.MessageDigest;
import kotlin.UByte;

/* JADX INFO: loaded from: classes2.dex */
public abstract class B {
    public static String a(Context context) {
        if (context != null) {
            try {
                Signature[] signatureArr = context.getPackageManager().getPackageInfo(C0616v.g().c(context), 64).signatures;
                if (signatureArr != null && signatureArr.length > 0) {
                    return a(signatureArr[0].toByteArray()).toUpperCase();
                }
            } catch (Exception unused) {
            }
        }
        return "-1";
    }

    private static String a(byte[] bArr) {
        StringBuffer stringBuffer = new StringBuffer();
        try {
            MessageDigest messageDigest = MessageDigest.getInstance(bz.f456a);
            messageDigest.reset();
            messageDigest.update(bArr);
            for (byte b : messageDigest.digest()) {
                int i = b & UByte.MAX_VALUE;
                if (Integer.toHexString(i).length() == 1) {
                    stringBuffer.append("0").append(Integer.toHexString(i));
                } else {
                    stringBuffer.append(Integer.toHexString(i));
                }
            }
        } catch (Exception e) {
            e.printStackTrace();
        }
        return stringBuffer.toString();
    }
}
