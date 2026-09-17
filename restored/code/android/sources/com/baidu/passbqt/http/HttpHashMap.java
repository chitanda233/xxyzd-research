package com.baidu.passbqt.http;

import com.baidu.passbqt.NoProguard;
import java.util.HashMap;
import java.util.Map;

/* JADX INFO: loaded from: classes.dex */
public class HttpHashMap implements NoProguard {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    private Map<String, String> f620a = new HashMap();

    public void a(String str) {
    }

    public Map a() {
        return this.f620a;
    }

    public void a(String str, String str2) {
        this.f620a.put(str, str2);
    }

    public void a(Map<? extends String, ? extends String> map) {
        this.f620a.putAll(map);
    }

    public String b(String str) {
        return this.f620a.get(str);
    }
}
