package com.baidu.mobads.sdk.internal.a;

import android.content.Context;
import android.os.Bundle;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import com.baidu.mobads.sdk.api.IAdInterListener;
import java.util.Map;

/* JADX INFO: loaded from: classes.dex */
public class e implements a {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    private c f402a;

    @Override // com.baidu.mobads.sdk.internal.a.a
    public Object handleEvent(String str, String str2, Object[] objArr) {
        return null;
    }

    public void a(IAdInterListener iAdInterListener) {
        if (iAdInterListener != null) {
            this.f402a = c.a(iAdInterListener, this);
        }
    }

    public void a(Context context) {
        this.f402a.a("onAttach", context);
    }

    public void a(Bundle bundle) {
        this.f402a.a("onCreate", bundle);
    }

    public View a(LayoutInflater layoutInflater, ViewGroup viewGroup, Bundle bundle) {
        Object objA = this.f402a.a("onCreateView", layoutInflater, viewGroup, bundle);
        if (objA instanceof View) {
            return (View) objA;
        }
        return null;
    }

    public void b(Bundle bundle) {
        this.f402a.a("onActivityCreated", bundle);
    }

    public void a() {
        this.f402a.a("onStart");
    }

    public void b() {
        this.f402a.a("onResume");
    }

    public void c() {
        this.f402a.a("onPause");
    }

    public void d() {
        this.f402a.a("onStop");
    }

    public void e() {
        this.f402a.a("onDestroyView");
    }

    public void f() {
        this.f402a.a("onDestroy");
    }

    public void g() {
        this.f402a.a("onDetach");
    }

    @Override // com.baidu.mobads.sdk.internal.a.a
    public IAdInterListener getDelegator() {
        return this.f402a.getDelegator();
    }

    @Override // com.baidu.mobads.sdk.api.IOAdEvent
    public void setTarget(Object obj) {
        this.f402a.setTarget(obj);
    }

    @Override // com.baidu.mobads.sdk.api.IOAdEvent
    public Object getTarget() {
        return this.f402a.getTarget();
    }

    @Override // com.baidu.mobads.sdk.api.IOAdEvent
    public String getType() {
        return this.f402a.getType();
    }

    @Override // com.baidu.mobads.sdk.api.IOAdEvent
    public int getCode() {
        return this.f402a.getCode();
    }

    @Override // com.baidu.mobads.sdk.api.IOAdEvent
    public String getMessage() {
        return this.f402a.getMessage();
    }

    @Override // com.baidu.mobads.sdk.api.IOAdEvent
    public Map<String, Object> getData() {
        return this.f402a.getData();
    }
}
