package cn.com.chinatelecom.account.api.net;

import android.net.Network;
import java.util.Map;

/* JADX INFO: loaded from: classes.dex */
public class RequestConfig {
    private static final int DEFAULT_CONNET_TIMEOUT = 3000;
    private static final int DEFAULT_READ_TIMEOUT = 3000;
    public boolean allowIpConnect;
    public String apiFlag;
    private int connetTimeout;
    public String domain;
    public Map<String, String> header;
    public String ipAddr;
    public boolean isRetry;
    public Network network;
    private int readTimeout;
    public int redirectCount;
    public String reqId;

    public int getConnetTimeout() {
        int i = this.connetTimeout;
        if (i > 0) {
            return i;
        }
        return 3000;
    }

    public int getReadTimeout() {
        int i = this.readTimeout;
        if (i > 0) {
            return i;
        }
        return 3000;
    }

    public RequestConfig(Builder builder) {
        this.connetTimeout = builder.connetTimeout;
        this.readTimeout = builder.readTimeout;
        this.network = builder.network;
        this.redirectCount = builder.redirectCount;
        this.apiFlag = builder.apiFlag;
        this.reqId = builder.reqId;
        this.isRetry = builder.isRetry;
        this.allowIpConnect = builder.allowIpConnect;
        this.ipAddr = builder.ipAddr;
        this.domain = builder.domain;
        this.header = builder.header;
    }

    public static class Builder {
        private boolean allowIpConnect;
        private String apiFlag;
        private int connetTimeout;
        private String domain;
        private Map<String, String> header;
        private String ipAddr;
        private boolean isRetry;
        private Network network;
        private int readTimeout;
        private int redirectCount;
        private String reqId;

        public Builder setConnetTimeout(int i) {
            this.connetTimeout = i;
            return this;
        }

        public Builder setReadTimeout(int i) {
            this.readTimeout = i;
            return this;
        }

        public Builder setNetwork(Network network) {
            this.network = network;
            return this;
        }

        public Builder setRedirectCount(int i) {
            this.redirectCount = i;
            return this;
        }

        public Builder setApiFlag(String str) {
            this.apiFlag = str;
            return this;
        }

        public Builder setRequestId(String str) {
            this.reqId = str;
            return this;
        }

        public Builder setRetry(boolean z) {
            this.isRetry = z;
            return this;
        }

        public Builder setIpConnect(boolean z, String str, String str2) {
            this.allowIpConnect = z;
            this.ipAddr = str;
            this.domain = str2;
            return this;
        }

        public Builder setRequestHeader(Map<String, String> map) {
            this.header = map;
            return this;
        }

        public RequestConfig build() {
            return new RequestConfig(this);
        }
    }
}
