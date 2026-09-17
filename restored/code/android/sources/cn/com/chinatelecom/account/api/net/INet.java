package cn.com.chinatelecom.account.api.net;

/* JADX INFO: loaded from: classes.dex */
public interface INet {
    ResponseInfo sendHttpRequest(String str, String str2, int i, RequestConfig requestConfig);

    ResponseInfo sendHttpsRequest(String str, String str2, int i, RequestConfig requestConfig, boolean z);

    ResponseInfo sendRequest(String str, String str2, int i, RequestConfig requestConfig, boolean z);
}
