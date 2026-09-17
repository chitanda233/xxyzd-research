package com.czhj.sdk.common.network;

import android.util.Base64;
import com.czhj.sdk.common.models.Config;
import com.czhj.sdk.common.utils.AESUtil;
import com.czhj.sdk.logger.SigmobLog;
import com.czhj.volley.DefaultRetryPolicy;
import com.czhj.volley.NetworkResponse;
import com.czhj.volley.Response;
import com.czhj.volley.VolleyError;
import java.util.Map;
import kotlinx.coroutines.DebugKt;

/* JADX INFO: loaded from: classes2.dex */
public class BuriedPointRequest extends SigmobRequest<NetworkResponse> {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    private final RequestListener f2258a;
    private byte[] b;
    private boolean c;

    public interface RequestListener {
        void onErrorResponse(VolleyError volleyError);

        void onSuccess();
    }

    private BuriedPointRequest(String str, String str2, RequestListener requestListener) {
        super(str, 1, null);
        this.b = null;
        this.f2258a = requestListener;
        setRetryPolicy(new DefaultRetryPolicy(5000, 2, 0.0f));
        setShouldCache(false);
        try {
            if (Config.sharedInstance().isEnc()) {
                this.b = AESUtil.Encrypt(str2.getBytes(), "KGpfzbYsn4T9Jyuq");
                this.c = true;
            }
        } catch (Exception e) {
            e.printStackTrace();
        } finally {
            if (!this.c) {
                this.b = str2.getBytes();
            }
        }
    }

    public static void BuriedPointSend(String str, RequestListener requestListener) {
        if ((str == null || str.isEmpty()) && requestListener != null) {
            requestListener.onErrorResponse(new VolleyError("body is empty"));
        }
        if (Networking.getBuriedPointRequestQueue() == null) {
            if (requestListener != null) {
                requestListener.onErrorResponse(new VolleyError("BuriedPointRequestQueue is empty"));
                return;
            }
            return;
        }
        try {
            Networking.getBuriedPointRequestQueue().add(new BuriedPointRequest(Config.sharedInstance().getLogUrl(), str, requestListener));
        } catch (Throwable th) {
            SigmobLog.e(th.getMessage());
            if (requestListener != null) {
                requestListener.onErrorResponse(new VolleyError("network is disconnect "));
            }
        }
    }

    @Override // com.czhj.volley.Request
    public void deliverError(VolleyError volleyError) {
        RequestListener requestListener;
        synchronized (this.mLock) {
            requestListener = this.f2258a;
        }
        SigmobLog.i("send dclog: " + getUrl() + " onErrorResponse");
        if (requestListener != null) {
            requestListener.onErrorResponse(volleyError);
        }
    }

    /* JADX INFO: Access modifiers changed from: protected */
    @Override // com.czhj.volley.Request
    public void deliverResponse(NetworkResponse networkResponse) {
        RequestListener requestListener;
        synchronized (this.mLock) {
            requestListener = this.f2258a;
        }
        SigmobLog.d("send dclog: " + getUrl() + " success");
        if (requestListener != null) {
            requestListener.onSuccess();
        }
    }

    @Override // com.czhj.sdk.common.network.SigmobRequest, com.czhj.volley.Request
    public byte[] getBody() {
        return this.b;
    }

    @Override // com.czhj.sdk.common.network.SigmobRequest, com.czhj.volley.Request
    public Map<String, String> getHeaders() {
        Map<String, String> headers = super.getHeaders();
        if (this.c) {
            headers.put("agn", Base64.encodeToString(AESUtil.generateNonce(), 2));
        }
        headers.put("gz", DebugKt.DEBUG_PROPERTY_VALUE_ON);
        return headers;
    }

    @Override // com.czhj.volley.Request
    public int getMaxLength() {
        return 100;
    }

    @Override // com.czhj.sdk.common.network.SigmobRequest, com.czhj.volley.Request
    protected Response<NetworkResponse> parseNetworkResponse(NetworkResponse networkResponse) {
        return Response.success(networkResponse, null);
    }
}
