package com.sigmob.sdk.downloader.core.breakpoint;

import android.util.SparseArray;
import java.util.HashMap;

/* JADX INFO: loaded from: classes3.dex */
public class k {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    private final HashMap<String, Integer> f3390a;
    private final SparseArray<String> b;

    k() {
        this(new HashMap(), new SparseArray());
    }

    k(HashMap<String, Integer> keyToIdMap, SparseArray<String> idToKeyMap) {
        this.f3390a = keyToIdMap;
        this.b = idToKeyMap;
    }

    public Integer a(com.sigmob.sdk.downloader.f task) {
        Integer num = this.f3390a.get(b(task));
        if (num != null) {
            return num;
        }
        return null;
    }

    public void a(int id) {
        String str = this.b.get(id);
        if (str != null) {
            this.f3390a.remove(str);
            this.b.remove(id);
        }
    }

    public void a(com.sigmob.sdk.downloader.f task, int id) {
        String strB = b(task);
        this.f3390a.put(strB, Integer.valueOf(id));
        this.b.put(id, strB);
    }

    String b(com.sigmob.sdk.downloader.f task) {
        return task.i() + task.h() + task.d();
    }
}
