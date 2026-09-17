package com.sigmob.sdk.mraid2;

import android.text.TextUtils;
import java.util.HashMap;

/* JADX INFO: loaded from: classes3.dex */
public class b {
    private static final b b = new b();

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    private final HashMap<String, e> f3524a = new HashMap<>();

    private b() {
    }

    public static b a() {
        return b;
    }

    public e a(String uuid) {
        if (TextUtils.isEmpty(uuid)) {
            return null;
        }
        e eVar = this.f3524a.get(uuid);
        this.f3524a.remove(uuid);
        return eVar;
    }

    public void a(String uuid, e value) {
        if (TextUtils.isEmpty(uuid)) {
            return;
        }
        this.f3524a.put(uuid, value);
    }

    public e b(String uuid) {
        if (TextUtils.isEmpty(uuid)) {
            return null;
        }
        return this.f3524a.get(uuid);
    }
}
