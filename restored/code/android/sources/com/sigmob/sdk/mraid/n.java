package com.sigmob.sdk.mraid;

import android.content.Context;
import android.view.View;
import org.json.JSONObject;

/* JADX INFO: loaded from: classes3.dex */
public abstract class n {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    protected String f3501a;
    String b;

    public interface a {
        void a(Context context, JSONObject args);

        void a(JSONObject args);

        void b(JSONObject args);

        void c(JSONObject args);

        void d(JSONObject args);

        void e(JSONObject args);

        void f(JSONObject args);

        void g(JSONObject args);

        void h(JSONObject args);
    }

    protected n(String uniqueId) {
        this.f3501a = uniqueId;
    }

    public abstract View a();

    public void a(String parentId) {
        this.b = parentId;
    }

    public abstract void b();

    public String c() {
        return this.b;
    }
}
