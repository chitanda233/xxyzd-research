package com.kwad.sdk.core.network;

import android.text.TextUtils;
import com.kwad.sdk.core.network.f;
import com.kwad.sdk.core.network.idc.DomainException;
import com.kwad.sdk.core.response.model.BaseResultData;
import com.kwad.sdk.export.proxy.AdHttpProxy;
import com.kwad.sdk.service.ServiceProvider;
import com.kwad.sdk.utils.aq;
import com.kwad.sdk.utils.by;
import java.util.Map;
import org.json.JSONException;
import org.json.JSONObject;

/* JADX INFO: loaded from: classes3.dex */
public abstract class l<R extends f, T extends BaseResultData> extends a<R> {
    public static String HTTP_CODE_ERROR_MSG = "网络错误";
    private static final String TAG = "Networking";
    private g<R, T> mListener = null;
    private final com.kwad.sdk.core.network.b.b mMonitorRecorder = com.kwad.sdk.core.network.b.c.MN();

    protected void afterParseData(T t) {
    }

    protected boolean enableCrashReport() {
        return true;
    }

    protected boolean enableMonitorReport() {
        return true;
    }

    protected boolean isPostByJson() {
        return true;
    }

    protected abstract T parseData(String str);

    public void request(g<R, T> gVar) {
        try {
            onRequest(gVar);
            fetch();
        } catch (Throwable th) {
            notifyOnErrorListener((f) null, e.aTj.errorCode, by.y(th));
            reportSdkCaughtException(th);
        }
    }

    private void onRequest(g<R, T> gVar) {
        this.mMonitorRecorder.MG();
        this.mListener = gVar;
    }

    @Override // com.kwad.sdk.core.network.a
    public void cancel() {
        super.cancel();
        this.mListener = null;
    }

    private void setMonitorRequestId(f fVar) {
        Map<String, String> header = fVar.getHeader();
        if (header != null) {
            String str = header.get(d.TRACK_ID_KEY);
            if (TextUtils.isEmpty(str)) {
                return;
            }
            this.mMonitorRecorder.eV(str);
        }
    }

    @Override // com.kwad.sdk.core.network.a
    protected void fetchImpl() {
        R r = null;
        c cVarDoPost = null;
        try {
            this.mMonitorRecorder.MK();
            R rCreateRequest = createRequest();
            try {
                notifyOnStartRequest(rCreateRequest);
                this.mMonitorRecorder.eR(rCreateRequest.getUrl()).eS(rCreateRequest.getUrl());
                setMonitorRequestId(rCreateRequest);
                if (!aq.isNetworkConnected(((com.kwad.sdk.service.a.f) ServiceProvider.get(com.kwad.sdk.service.a.f.class)).getContext())) {
                    notifyOnErrorListener(rCreateRequest, e.aTc.errorCode, e.aTc.msg);
                    this.mMonitorRecorder.en(e.aTc.errorCode).eT(e.aTc.msg);
                } else {
                    try {
                        String url = rCreateRequest.getUrl();
                        AdHttpProxy adHttpProxyES = com.kwad.sdk.h.ES();
                        if (adHttpProxyES instanceof com.kwad.sdk.core.network.c.b) {
                            this.mMonitorRecorder.eU("ok_http").MJ();
                        } else {
                            this.mMonitorRecorder.eU("http").MJ();
                        }
                        if (isPostByJson()) {
                            cVarDoPost = adHttpProxyES.doPost(url, rCreateRequest.getHeader(), rCreateRequest.getBody());
                        } else {
                            cVarDoPost = adHttpProxyES.doPost(url, rCreateRequest.getHeader(), rCreateRequest.getBodyMap());
                        }
                        com.kwad.sdk.core.d.c.i(TAG, "url: " + url + ", response: " + cVarDoPost);
                    } catch (Exception e) {
                        notifyOnErrorListener(rCreateRequest, e.aTj.errorCode, by.y(e));
                        com.kwad.sdk.core.d.c.printStackTraceOnly(e);
                        this.mMonitorRecorder.eT("requestError:" + e.getMessage());
                    }
                    this.mMonitorRecorder.MH().MI().eq(com.kwad.sdk.ip.direct.a.getType());
                    try {
                        onResponse(rCreateRequest, cVarDoPost);
                    } catch (Exception e2) {
                        notifyOnErrorListener(rCreateRequest, e.aTj.errorCode, by.y(e2));
                        this.mMonitorRecorder.eT("onResponseError:" + e2.getMessage());
                        com.kwad.sdk.core.d.c.w(TAG, "jky onResponseError: " + rCreateRequest.getUrl());
                        com.kwad.sdk.core.d.c.printStackTraceOnly(e2);
                    }
                }
                try {
                    if (enableMonitorReport()) {
                        this.mMonitorRecorder.report();
                    }
                } catch (Exception unused) {
                }
            } catch (Throwable th) {
                th = th;
                r = rCreateRequest;
                try {
                    try {
                        this.mMonitorRecorder.eT("requestError:" + th.getMessage());
                    } finally {
                        try {
                            if (enableMonitorReport()) {
                                this.mMonitorRecorder.report();
                            }
                        } catch (Exception unused2) {
                        }
                    }
                } catch (Exception unused3) {
                }
                notifyOnErrorListener(r, e.aTj.errorCode, by.y(th));
                com.kwad.sdk.core.d.c.printStackTrace(th);
                try {
                    if (enableMonitorReport()) {
                    }
                } catch (Exception unused4) {
                }
            }
        } catch (Throwable th2) {
            th = th2;
        }
    }

    @Override // com.kwad.sdk.core.network.a
    protected void onResponse(R r, c cVar) {
        if (cVar == null) {
            notifyOnErrorListener(r, e.aTc.errorCode, e.aTc.msg);
            this.mMonitorRecorder.eT("responseBase is null");
            com.kwad.sdk.core.d.c.e(TAG, "request responseBase is null");
            return;
        }
        this.mMonitorRecorder.en(cVar.code);
        checkIpDirect(cVar);
        if (TextUtils.isEmpty(cVar.aSY) || !cVar.Mq()) {
            notifyOnErrorListener(r, cVar, HTTP_CODE_ERROR_MSG);
            this.mMonitorRecorder.eT("httpCodeError:" + cVar.code + ":" + cVar.aSY);
            com.kwad.sdk.core.d.c.w(TAG, "request responseBase httpCodeError:" + cVar.code);
            return;
        }
        try {
            parseCommonData(r.getUrl(), cVar.aSY);
            BaseResultData data = parseData(cVar.aSY);
            afterParseData(data);
            if (cVar.aSY != null) {
                this.mMonitorRecorder.aB(cVar.aSY.length()).ML().ep(data.result);
            }
            if (!data.isResultOk()) {
                this.mMonitorRecorder.eT("serverCodeError:" + data.result + ":" + data.errorMsg);
                if (data.notifyFailOnResultError()) {
                    notifyOnErrorListener(r, data.result, data.errorMsg);
                    return;
                }
            }
            if (data.isDataEmpty()) {
                notifyOnErrorListener(r, e.aTe.errorCode, !TextUtils.isEmpty(data.testErrorMsg) ? data.testErrorMsg : e.aTe.msg);
            } else {
                checkAndSetHasData(data);
                notifyOnSuccess(r, data);
            }
        } catch (Exception e) {
            notifyOnErrorListener(r, e.aTd.errorCode, e.aTd.msg);
            com.kwad.sdk.core.d.c.printStackTraceOnly(e);
            this.mMonitorRecorder.eT("parseDataError:" + e.getMessage());
        }
    }

    private void checkIpDirect(c cVar) {
        com.kwad.sdk.service.a.f fVar;
        if (cVar == null || cVar.Mq() || (fVar = (com.kwad.sdk.service.a.f) ServiceProvider.get(com.kwad.sdk.service.a.f.class)) == null || !aq.isNetworkConnected(fVar.getContext())) {
            return;
        }
        com.kwad.sdk.ip.direct.a.RB();
    }

    private void checkAndSetHasData(BaseResultData baseResultData) {
        if (baseResultData.hasData()) {
            this.mMonitorRecorder.eo(1);
        }
    }

    private void parseCommonData(String str, String str2) {
        try {
            q.Mu().W(str, new JSONObject(str2).optString("requestSessionData"));
        } catch (JSONException e) {
            e.printStackTrace();
        }
    }

    private void notifyOnStartRequest(R r) {
        g<R, T> gVar = this.mListener;
        if (gVar == null) {
            return;
        }
        gVar.onStartRequest(r);
    }

    private void notifyOnErrorListener(R r, c cVar, String str) {
        String url = r.getUrl();
        DomainException domainException = new DomainException(cVar.aSW, cVar.aSX);
        com.kwad.sdk.core.network.idc.a.My().a(url, getHostTypeByUrl(url), domainException);
        notifyOnErrorListener(r, cVar.code, str);
    }

    private String getHostTypeByUrl(String str) {
        return str.contains("/rest/zt/emoticon/package/list") ? "zt" : "api";
    }

    private void notifyOnErrorListener(R r, int i, String str) {
        try {
            h.Mr().b(r, i);
        } catch (Throwable th) {
            reportSdkCaughtException(th);
        }
        g<R, T> gVar = this.mListener;
        if (gVar == null) {
            return;
        }
        gVar.onError(r, i, str);
        this.mMonitorRecorder.MM();
    }

    private void reportSdkCaughtException(Throwable th) {
        if (enableCrashReport()) {
            ServiceProvider.reportSdkCaughtException(th);
        } else {
            com.kwad.sdk.core.d.c.printStackTrace(th);
        }
    }

    private void notifyOnSuccess(R r, T t) {
        if (com.kwad.sdk.core.network.idc.a.My().MA()) {
            String hostTypeByUrl = getHostTypeByUrl(r.getUrl());
            if ("api".equals(hostTypeByUrl)) {
                com.kwad.sdk.core.network.idc.a.My().eL(hostTypeByUrl);
            }
        }
        g<R, T> gVar = this.mListener;
        if (gVar == null) {
            return;
        }
        gVar.onSuccess(r, t);
        this.mMonitorRecorder.MM();
    }
}
