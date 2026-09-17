package com.kwad.sdk.utils;

import android.content.Context;
import android.os.Process;

/* JADX INFO: loaded from: classes3.dex */
public final class AbiUtil {
    private static Abi bob;

    public enum Abi {
        UNKNOWN,
        ARMEABI_V7A,
        ARM64_V8A
    }

    public static String cJ(Context context) {
        return isArm64(context) ? "arm64-v8a" : "armeabi-v7a";
    }

    public static boolean isArm64(Context context) {
        return cK(context) == Abi.ARM64_V8A;
    }

    private static Abi cK(Context context) {
        Abi abi = bob;
        if (abi != null) {
            return abi;
        }
        Abi abi2 = Process.is64Bit() ? Abi.ARM64_V8A : Abi.ARMEABI_V7A;
        bob = abi2;
        return abi2;
    }
}
