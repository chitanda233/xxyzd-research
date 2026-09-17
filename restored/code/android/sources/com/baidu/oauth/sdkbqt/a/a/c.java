package com.baidu.oauth.sdkbqt.a.a;

import android.os.Looper;
import com.baidu.passbqt.http.HttpResponseHandler;
import java.util.HashMap;

/* JADX INFO: loaded from: classes.dex */
class c extends HttpResponseHandler {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    final /* synthetic */ f f548a;
    final /* synthetic */ a b;

    @Override // com.baidu.passbqt.http.HttpResponseHandler
    protected void a() {
    }

    /* JADX WARN: 'super' call moved to the top of the method (can break code semantics) */
    c(a aVar, Looper looper, boolean z, f fVar) {
        super(looper, z);
        this.b = aVar;
        this.f548a = fVar;
    }

    @Override // com.baidu.passbqt.http.HttpResponseHandler
    protected void b() {
        this.f548a.b();
    }

    @Override // com.baidu.passbqt.http.HttpResponseHandler
    protected void a(int i, String str, HashMap<String, String> map) {
        try {
            this.f548a.a(i, str, map);
        } catch (Throwable th) {
            a(th, str);
        }
    }

    @Override // com.baidu.passbqt.http.HttpResponseHandler
    protected void a(Throwable th, String str) {
        this.b.a(this.f548a, th, str);
    }
}
