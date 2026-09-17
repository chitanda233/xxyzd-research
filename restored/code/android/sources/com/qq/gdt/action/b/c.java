package com.qq.gdt.action.b;

import com.qq.gdt.action.ActionType;
import java.util.Arrays;
import java.util.HashSet;
import java.util.Set;

/* JADX INFO: loaded from: classes3.dex */
public class c {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    private static final Set<String> f3023a = new HashSet(Arrays.asList("TICKET", "RESUME", "PAUSE", "ENTER_BACKGROUND", "ENTER_FOREGROUND"));

    public static long a() {
        return System.currentTimeMillis() - 2592000000L;
    }

    public static boolean a(String str) {
        return ActionType.START_APP.equals(str) || "TENCENT_INNER_START_APP".equals(str);
    }

    public static boolean b(String str) {
        return f3023a.contains(str);
    }
}
