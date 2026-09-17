package com.czhj.sdk.common.network;

import android.text.TextUtils;
import com.czhj.sdk.common.ClientMetadata;
import com.czhj.volley.DefaultRetryPolicy;
import com.czhj.volley.NetworkResponse;
import com.czhj.volley.Request;
import com.czhj.volley.Response;
import com.czhj.volley.VolleyError;
import com.czhj.volley.toolbox.HttpHeaderParser;
import java.util.Locale;
import java.util.Map;
import java.util.TreeMap;

/* JADX INFO: loaded from: classes2.dex */
public abstract class SigmobRequest<T> extends Request<T> {
    protected static final String AESKEY = "KGpfzbYsn4T9Jyuq";

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    private final String f2268a;

    protected SigmobRequest(String str, int i, Response.ErrorListener errorListener) {
        super(i, str, errorListener);
        this.f2268a = str;
        setRetryPolicy(new DefaultRetryPolicy(5000, 2, 0.0f));
        setShouldCache(false);
    }

    @Override // com.czhj.volley.Request
    public byte[] getBody() {
        String strGenerateBodyFromParams = SigmobRequestUtil.generateBodyFromParams(getParams(), getUrl());
        if (strGenerateBodyFromParams == null) {
            return null;
        }
        return strGenerateBodyFromParams.getBytes();
    }

    @Override // com.czhj.volley.Request
    public String getBodyContentType() {
        return super.getBodyContentType();
    }

    @Override // com.czhj.volley.Request
    public Map<String, String> getHeaders() {
        TreeMap treeMap = new TreeMap();
        if (!SigmobRequestUtil.a(this.f2268a)) {
            return treeMap;
        }
        String language = Locale.getDefault().getLanguage();
        if (ClientMetadata.getInstance() != null) {
            Locale deviceLocale = ClientMetadata.getInstance().getDeviceLocale();
            if (!deviceLocale.getLanguage().trim().isEmpty()) {
                language = deviceLocale.getLanguage().trim();
            }
        }
        if (!TextUtils.isEmpty(language)) {
            treeMap.put(ResponseHeader.ACCEPT_LANGUAGE.getKey(), language);
        }
        return treeMap;
    }

    public String getOriginalUrl() {
        return this.f2268a;
    }

    @Override // com.czhj.volley.Request
    public String getUrl() {
        return super.getUrl();
    }

    @Override // com.czhj.volley.Request
    protected VolleyError parseNetworkError(VolleyError volleyError) {
        return super.parseNetworkError(volleyError);
    }

    @Override // com.czhj.volley.Request
    protected Response<T> parseNetworkResponse(NetworkResponse networkResponse) {
        return Response.success(networkResponse, HttpHeaderParser.parseCacheHeaders(networkResponse));
    }
}
