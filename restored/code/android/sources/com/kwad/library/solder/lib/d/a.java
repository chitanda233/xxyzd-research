package com.kwad.library.solder.lib.d;

import android.os.Process;
import java.util.HashMap;
import java.util.Map;

/* JADX INFO: loaded from: classes3.dex */
public final class a {
    private static String aFD;
    private static String aFE;
    private static final Map<String, String> aFF;

    static {
        HashMap map = new HashMap();
        aFF = map;
        map.put("mips", "mips");
        map.put("mips64", "mips64");
        map.put("x86", "x86");
        map.put("x86_64", "x86_64");
        map.put("arm64", "arm64-v8a");
    }

    private static boolean is64Bit() {
        return Process.is64Bit();
    }

    public static String EJ() {
        return is64Bit() ? "arm64-v8a" : "armeabi-v7a";
    }
}
